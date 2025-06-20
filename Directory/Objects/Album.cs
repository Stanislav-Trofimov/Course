using Course.Global.Objects;
using Newtonsoft.Json;

namespace Course.Directory.Objects
{
    public class Album : DirectoryObject
    {
        [JsonIgnore]
        public List<Song> Songs { get; set; }
        [JsonIgnore]
        public Band Band { get; set; }

        public List<string> SongsIds { get; private set; }
        public string BandId { get; private set; }

        [JsonConstructor]
        public Album(string id, string name, string icon, List<string> genres, List<string> songsIds, string bandId) : base(id, name, icon, genres)
        {
            SongsIds = songsIds;
            BandId = bandId;
        }
    }
}
