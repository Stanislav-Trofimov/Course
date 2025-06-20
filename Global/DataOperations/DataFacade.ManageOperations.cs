using Course.Global.Objects;
using Course.Library.Objects;
using Course.Library.ObjectSettings;

namespace Course.Global.DataOperations;

public partial class DataFacade // ManageOperations частина
{
    public void PropertyChange<TObject>(TObject target, string value, Settings settings) where TObject : CustomObject
    {
        UpdatePropertyCommand<TObject> command = new UpdatePropertyCommand<TObject>(target, value, settings);

        _dispatcher.Send(command);
    }

    public void GenresChange<TObject>(TObject target, List<string> value, Settings settings) where TObject : CustomObject
    {
        UpdateGenresCommand<TObject> command = new UpdateGenresCommand<TObject>(target, value, settings);

        _dispatcher.Send(command);
    }

    public void AddSongToPlaylist(Playlist target, ISong value)
    {
        AddSongToPlaylistCommand command = new AddSongToPlaylistCommand(target, value, Settings.AddSong);

        _dispatcher.Send(command);

        AddSong(value);
    }

    public void RemoveSongToPlaylist(Playlist target, ISong value)
    {
        RemoveSongToPlaylistCommand command = new RemoveSongToPlaylistCommand(target, value, Settings.RemoveSong);

        _dispatcher.Send(command);

        RemoveSong(value);
    }

    public void AddPlaylist(Playlist value)
    {
        List<Playlist> playlists = GlobalPlaylist;

        if (!playlists.Contains(value))
            playlists.Add(value);
    }
    public void RemovePlaylist(Playlist value)
    {
        List<Playlist> playlists = GlobalPlaylist;

        if (playlists.Contains(value))
            playlists.Remove(value);
    }

    public void AddSong(ISong value)
    {
        List<ISong> playlists = GlobalLibrarySongs;

        if (!playlists.Contains(value))
            playlists.Add(value);
    }
    public void RemoveSong(ISong value)
    {
        List<ISong> playlists = GlobalLibrarySongs;

        if (playlists.Contains(value))
            playlists.Remove(value);
    }
}
