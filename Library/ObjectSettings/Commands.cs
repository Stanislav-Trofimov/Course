using Course.Global.Objects;
using Course.Library.Objects;

namespace Course.Library.ObjectSettings;

public interface ICommand { }

class UpdatePropertyCommand<TObject> : ICommand where TObject : CustomObject // Для Name, Icon, Lyrics
{
    public TObject Target { get; }
    public string Value { get; }
    public Settings Settings { get; }

    public UpdatePropertyCommand(TObject target, string value, Settings settings)
    {
        Target = target;
        Value = value;
        Settings = settings;
    }
}

class UpdateGenresCommand<TObject> : ICommand where TObject : CustomObject // Для Genres
{
    public TObject Target { get; }
    public List<string> Value { get; }
    public Settings Settings { get; }

    public UpdateGenresCommand(TObject target, List<string> value, Settings settings)
    {
        Target = target;
        Value = value;
        Settings = settings;
    }
}

class AddSongToPlaylistCommand : ICommand
{
    public Playlist Target { get; }
    public ISong Value { get; }
    public Settings Settings { get; }

    public AddSongToPlaylistCommand(Playlist target, ISong value, Settings settings)
    {
        Target = target;
        Value = value;
        Settings = settings;
    }
}

class RemoveSongToPlaylistCommand : ICommand
{
    public Playlist Target { get; }
    public ISong Value { get; }
    public Settings Settings { get; }

    public RemoveSongToPlaylistCommand(Playlist target, ISong value, Settings settings)
    {
        Target = target;
        Value = value;
        Settings = settings;
    }
}
