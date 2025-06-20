using Newtonsoft.Json;

namespace Course.Global.Objects
{
    public abstract class DirectoryObject : IObject
    {
        public string Id { get; init; }
        public string Name { get; init; }
        public string Icon { get; init; }
        public List<string> Genres { get; init; }

        [JsonConstructor]
        protected DirectoryObject(string id, string name, string icon, List<string> genres) // Load
        { 
            Id = id;
            Name = name;
            Icon = icon;
            Genres = genres;
        }
    }
}
