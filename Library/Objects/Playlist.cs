using Course.Global.Objects;
using Newtonsoft.Json;

namespace Course.Library.Objects
{
    public class Playlist : CustomObject
    {
        [JsonIgnore]
        public List<ISong> Songs { get; set; }

        public List<string> SongsIds { get; private set; }


        [JsonConstructor]
        public Playlist(string id, string name, string icon, List<string> genres, List<string> songsIds)
            : base(id, name, icon, genres)
        {
            SongsIds = songsIds;
        }

        public Playlist(string name, string icon, List<string> genres)
            : base(name ?? "Без назви", icon, genres ?? new List<string>()) { }
    }
}
