using Course.Global.Objects;
using Newtonsoft.Json;

namespace Course.Directory.Objects
{
    public class Band : DirectoryObject
    {
        [JsonIgnore]
        public List<Album> Albums { get; set; }

        public List<string> AlbumsIds { get; private set; }

        [JsonConstructor]
        public Band(string id, string name, string icon, List<string> genres, List<string> albumsIds) : base(id, name, icon, genres)
        {
            AlbumsIds = albumsIds;
        }
    }
}
