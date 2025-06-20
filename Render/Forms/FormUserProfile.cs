using Course.Global.DataOperations;
using Course.Library.Objects;
using Course.Render.Controls;

namespace Course.Render.Forms;

public partial class FormUserProfile : Form
{
    private DataFacade _facade;
    private List<Playlist> _playlists;

    public FormUserProfile(DataFacade facade)
    {
        _facade = facade;
        _playlists = facade.GlobalPlaylist;

        InitializeComponent();
    }

    private void FormUserProfile_Load(object sender, EventArgs e)
    {
        DisplayPlaylistList();
    }

    private void buttonAddPlaylist_Click(object sender, EventArgs e)
    {
        FormAddNewPlaylist addNewPlaylist = new FormAddNewPlaylist(_playlists);

        if (addNewPlaylist.ShowDialog() == DialogResult.OK)
        {
            DisplayPlaylistList();
        }
    }

    private void DisplayPlaylistList()
    {
        flowLayoutPlaylist.Controls.Clear();

        foreach (Playlist obj in _playlists)
        {
            ObjectControl objectControl = new ObjectControl(_facade);
            objectControl.ObjectData = obj;
            flowLayoutPlaylist.Controls.Add(objectControl);
        }
    }
}
