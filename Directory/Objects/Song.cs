using Course.Global.Objects;
using Newtonsoft.Json;

namespace Course.Directory.Objects
{
    public class Song : DirectoryObject, ISong
    {
        [JsonIgnore]
        public Album Album { get; set; }

        public string AlbumId { get; private set; }

        public List<string> Artists { get; private set; }

        //public TimeSpan Duration { get; private set; }

        public string Lyrics { get; private set; }

        [JsonConstructor]
        public Song(string id, string name, string icon, List<string> genres, string albumId, List<string> artists, string lyrics) : base(id, name, icon, genres)
        {
            AlbumId = albumId;
            Artists = artists;
            //Duration = duration;
            Lyrics = lyrics;
        }
    }
}
