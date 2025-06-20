using Course.Directory.Data.Repositories;

namespace Course.Directory.Data
{
    public class DirectoryData
    {
        public BandRepository BandManager { get; init; }
        public AlbumRepository AlbumManager { get; init; }
        public SongRepository SongManager { get; init; }

        public DirectoryData()
        {
            BandManager = new BandRepository();
            AlbumManager = new AlbumRepository();
            SongManager = new SongRepository();
        }

        public void LoadDirectory() // Повне завантаження довіднику (тільки незмінювані об'єкти)
        {
            BandManager.Load();
            AlbumManager.Load();
            SongManager.Load();
            Console.WriteLine();

            // Побудова зв'язків між піснями та альбомами
            ConnectEntities(AlbumManager.Objects, SongManager.Objects, 
                album => album.SongsIds, son => son.Id,
                (album, songs) => album.Songs = songs, (son, album) => son.Album = album);

            // Побудова зв'язків між альбомами та групами
            ConnectEntities(BandManager.Objects, AlbumManager.Objects,
                band => band.AlbumsIds, album => album.Id,
                (band, albums) => band.Albums = albums, (albums, band) => albums.Band = band);
        }

        public void SaveDirectory() // Повне збереження довіднику (тільки незмінювані об'єкти)
        {
            BandManager.Save();
            AlbumManager.Save();
            SongManager.Save();
        }

        private void ConnectEntities<TParent, TSon>(
            List<TParent> globalParentsList, List<TSon> globalSonsList,                          // Задаємо глобальний список батьків та синів
            Func<TParent, List<string>> getSonsId, Func<TSon, string> getSonId,                  // Задаємо Func делегати
            Action<TParent, List<TSon>> setSons, Action<TSon, TParent> setParent)                // Задаємо Action делегати
        {
            foreach (TParent parent in globalParentsList)
            {
                List<TSon?> sons = getSonsId.Invoke(parent)                                         // Знаходження підходящих для батька синів
                    .Select(id => globalSonsList.FirstOrDefault(son => getSonId.Invoke(son) == id)) // Беремо з батьківського списку id синів та шукаємо збіги id в глобальному списку синів 
                    .Where(son => son != null)                                                      // Видалення всіх null посилань
                    .ToList();                                                                      // Конвертація у List
                
                foreach (TSon son in sons)                                                          // Поєднання кожного сина з поточним батьком
                    setParent.Invoke(son, parent);

                setSons.Invoke(parent, sons);                                                       // Поєднання поточного батька з відфільтрованим списком синів
            }
        }
    }
}
