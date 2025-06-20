using Course.Global.Objects;
using Newtonsoft.Json;

namespace Course.Library.Objects
{
    public class CustomSong : CustomObject, ISong
    {
        public string AlbumName { get; set; }

        public List<string> Artists { get; set; }

        //public TimeSpan Duration { get; set; }

        public string Lyrics { get; set; }

        [JsonConstructor]
        public CustomSong
            (string id, string name, string icon, List<string> genres, List<string> artists, string lyrics, string album)
            : base(id, name, icon, genres)
        {
            AlbumName = album;
            Artists = artists;
            //Duration = duration;
            Lyrics = lyrics;
        }

        public CustomSong
            (string name, string icon, List<string> genres, List<string> artists, string lyrics, string album)
            : base(name ?? "Без назви", icon, genres ?? new List<string>())
        {
            AlbumName = album ?? "Без альбому";
            Artists = artists ?? new List<string>();
            //Duration = duration;
            Lyrics = lyrics ?? "Без тексту";
        }
    }
}
