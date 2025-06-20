using Course.Directory.Objects;
using Course.Global.Objects;
using Course.Library.Objects;

namespace Course.Global.DataOperations;

public partial class DataFacade // GlobalData частина
{
    public List<Band> GlobalBands => _directoryData.BandManager.Objects;
    public List<Album> GlobalAlbums => _directoryData.AlbumManager.Objects;
    public List<Song> GlobalDirectorySongs => _directoryData.SongManager.Objects;
    public List<Playlist> GlobalPlaylist => _libraryData.PlaylistDM.Objects;
    public List<ISong> GlobalLibrarySongs => _libraryData.SongDM.Objects;

    public void LoadProgramData()
    {
        _directoryData.LoadDirectory();
        _libraryData.LoadLibrary();
    }

    public void SaveProgramData()
    {
        _directoryData.SaveDirectory();
        _libraryData.SaveLibrary();
    }
}
