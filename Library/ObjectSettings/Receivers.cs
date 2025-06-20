using Course.Global.Objects;
using Course.Library.Objects;

namespace Course.Library.ObjectSettings;

interface IReceiver<TObject, TValue> where TObject : CustomObject 
{
    public void Action(TObject item, TValue value);
}

class NameReceiver<TObject> : IReceiver<TObject, string> where TObject : CustomObject
{
    public void Action(TObject item, string value) => item.Name = value;
}

class IconReceiver<TObject> : IReceiver<TObject, string> where TObject : CustomObject
{
    public void Action(TObject item, string value) => item.Icon = value;
}

class GenresReceiver<TObject> : IReceiver<TObject, List<string>> where TObject : CustomObject
{
    public void Action(TObject item, List<string> value) => item.Genres = value;
}

class LyricsReceiver : IReceiver<CustomSong, string>
{
    public void Action(CustomSong item, string value) => item.Lyrics = value;
}

class AlbumNameReceiver : IReceiver<CustomSong, string>
{
    public void Action(CustomSong item, string value) => item.AlbumName = value;
}

class ArtistsReceiver : IReceiver<CustomSong, List<string>>
{
    public void Action(CustomSong item, List<string> value) => item.Artists = value;
}

class AddSongReceiver : IReceiver<Playlist, ISong>
{
    public void Action(Playlist item, ISong value)
    {
        if (item.Songs.Contains(value))
            throw new InvalidOperationException($"Пісня {value.Name} вже існує");

        item.Songs.Add(value);
    }
}

class RemoveSongReceiver : IReceiver<Playlist, ISong>
{
    public void Action(Playlist item, ISong value)
    {
        if (!item.Songs.Contains(value))
            throw new InvalidOperationException($"Пісні {value.Name} не існує. Її неможливо видалити.");

        item.Songs.Remove(value);
    }
}
