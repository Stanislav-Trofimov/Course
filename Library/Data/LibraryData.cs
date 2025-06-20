using Course.Library.Data.Repositories;

namespace Course.Library.Data
{
    public class LibraryData
    {
        public PlaylistRepository PlaylistDM { get; init; }
        public LibrarySongRepository SongDM { get; init; }

        public LibraryData()
        {
            PlaylistDM = new PlaylistRepository();
            SongDM = new LibrarySongRepository();
        }

        public void LoadLibrary()
        {
            PlaylistDM.Load();
            SongDM.Load();

            ConnectEntities(PlaylistDM.Objects, SongDM.Objects,
                playlist => playlist.SongsIds, song => song.Id,
                (playlist, songs) => playlist.Songs = songs);
        }

        public void SaveLibrary()
        {
            PlaylistDM.Save();
            SongDM.Save();
        }

        private void ConnectEntities<TParent, TSon>(
            List<TParent> globalParentsList, List<TSon> globalSonsList,
            Func<TParent, List<string>> getSonsId, Func<TSon, string> getSonId,
            Action<TParent, List<TSon>> setSons)
        {
            if (globalParentsList == null)
            {
                Console.WriteLine("ConnectEntities: globalParentsList дорівнює null. Пропуск з'єднання.");
                return;
            }
            
            if (globalSonsList == null || !globalSonsList.Any())
            {
                Console.WriteLine("ConnectEntities: globalSonsList дорівнює null або пустий. Пропуск логіки з'єднання для синів.");
                
                foreach (TParent parent in globalParentsList)
                {
                    setSons.Invoke(parent, new List<TSon>());
                }

                return;
            }

            foreach (TParent parent in globalParentsList)
            {
                List<string> sonIds = getSonsId.Invoke(parent);
                if (sonIds == null || !sonIds.Any())
                {
                    setSons.Invoke(parent, new List<TSon>());
                    continue;
                }

                List<TSon?> sons = sonIds
                    .Select(id => globalSonsList.FirstOrDefault(son => getSonId.Invoke(son) == id))
                    .Where(son => son != null)
                    .ToList();

                setSons.Invoke(parent, sons);
            }
        }
    }
}
