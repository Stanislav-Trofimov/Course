using Course.Directory.Objects;
using Course.Global.DataOperations;
using Course.Global.Objects;
using Course.Render.Controls;
using Course.Render.Forms;
using System.Collections;
using Timer = System.Windows.Forms.Timer;

namespace Course.Render;

public partial class FormFeed : Form
{
    protected FormUserProfile _userProfileForm;
    protected FormFullList _formFullList;

    protected readonly Timer _hidePanelTimer;
    protected readonly DataFacade _facade;

    public FormFeed(DataFacade facade)
    {
        _facade = facade;

        InitializeComponent();

        _hidePanelTimer = new Timer();
        _hidePanelTimer.Interval = 20;
        _hidePanelTimer.Tick += HidePanelTimer_Tick;
        _hidePanelTimer.Enabled = false;
    }

    private void HidePanelTimer_Tick(object? sender, EventArgs e)
    {
        _hidePanelTimer.Stop();

        panelDropdown.Visible = false;
        checkedListBoxGenres.Visible = false;
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        _facade.LoadProgramData();

        LoadAndDisplayAllData();
    }

    private void LoadAndDisplayAllData()
    {
        List<Band> bands = _facade.GlobalBands;
        List<Album> albums = _facade.GlobalAlbums;
        List<Song> songs = _facade.GlobalDirectorySongs;
        Random random = new Random();

        Binding(flowLayoutBands, labelTitleBands, bands, random);
        Binding(flowLayoutAlbums, labelTitleAlbums, albums, random);
        Binding(flowLayoutSongs, labelTitleSongs, songs, random);
    }
    private void Binding<T>(FlowLayoutPanel panel, Label label, List<T> objects, Random random) where T : DirectoryObject
    {
        panel.Controls.Clear();

        if (objects == null || objects.Count == 0)
        {
            label.Text = "Немає даних";
            return;
        }

        label.Text = $"{typeof(T).Name}s";

        // Виділену частину винести

        List<T> listToShuffle = new List<T>(objects);

        int n = listToShuffle.Count;
        while (n > 1)
        {
            n--;
            int k = random.Next(n + 1);
            (listToShuffle[n], listToShuffle[k]) = (listToShuffle[k], listToShuffle[n]);
        }

        // Виділену частину винести

        int itemsToDisplay = Math.Min(10, listToShuffle.Count);

        List<T> displayObjects = listToShuffle.Take(itemsToDisplay).ToList();

        foreach (T obj in displayObjects)
        {
            ObjectControl objectControl = new ObjectControl(_facade);

            objectControl.ObjectData = obj;

            panel.Controls.Add(objectControl);
        }
    }

    private void TextBoxSearch_Click(object sender, EventArgs e)
    {
        if (!panelDropdown.Visible)
            panelDropdown.Visible = true;
    }

    private void Panel_Leave(object sender, EventArgs e)
    {
        if (!_hidePanelTimer.Enabled)
            _hidePanelTimer.Start();
    }

    private void Panel_Enter(object sender, EventArgs e)
    {
        if (_hidePanelTimer.Enabled)
            _hidePanelTimer.Stop();

        panelDropdown.Visible = true;
    }

    private void buttonUserProfile_Click(object sender, EventArgs e)
    {
        if (_userProfileForm == null || _userProfileForm.IsDisposed)
        {
            _userProfileForm = new FormUserProfile(_facade);
            _userProfileForm.Show();
        }
        else
        {
            _userProfileForm.BringToFront();
        }
    }

    private void buttonGenresFilter_Click(object sender, EventArgs e)
    {
        if (!checkedListBoxGenres.Visible)
            checkedListBoxGenres.Visible = true;
        else
            checkedListBoxGenres.Visible = false;
    }

    private void buttonClearSearchResult_Click(object sender, EventArgs e)
    {
        LoadAndDisplayAllData();
        buttonClearSearchResult.Visible = false;
    }

    private void buttonShowAllBands_Click(object sender, EventArgs e) => ShowFormFullList(typeof(Band));
    private void buttonShowAllAlbums_Click(object sender, EventArgs e) => ShowFormFullList(typeof(Album));
    private void buttonShowAllSongs_Click(object sender, EventArgs e) => ShowFormFullList(typeof(Song));
    private void ShowFormFullList(Type type)
    {
        if (_formFullList == null || _formFullList.IsDisposed)
            _formFullList = new FormFullList(_facade);

        IEnumerable? fullListOfData = null;

        if (type == typeof(Band))       fullListOfData = _facade.GlobalBands;
        else if (type == typeof(Album)) fullListOfData = _facade.GlobalAlbums;
        else if (type == typeof(Song))  fullListOfData = _facade.GlobalDirectorySongs;

        if (fullListOfData == null)
        {
            MessageBox.Show($"Не вдалося завантажити дані для типу: {type.Name}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        _formFullList.ShowFullList(fullListOfData, type);

        _formFullList.Show();
        _formFullList.BringToFront();
    }
}
