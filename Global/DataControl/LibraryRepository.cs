using Course.Global.Objects;

namespace Course.Global.DataControl
{
    public abstract class LibraryRepository<T> : DirectoryRepository<T> where T : IObject
    {
        private string _fileName = typeof(T).Name;
        protected override string FilePath => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
            "Vibe",
            "Data",
            $"{(_fileName == "CustomSong" ? _fileName[6..] : _fileName)}Data.json");
    }
}
