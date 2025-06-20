using Course.Library.Objects;

namespace Course.Render.Forms;

public partial class FormAddNewPlaylist : Form
{
    private List<Playlist> _playlists;

    private string? _selectedName;
    private string? _selectedIcon;
    private List<string>? _selectedGenres;

    public FormAddNewPlaylist(List<Playlist> playlists)
    {
        _playlists = playlists;

        InitializeComponent();
    }

    private void buttonIconChoose_Click(object sender, EventArgs e)
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();

        openFileDialog.Title = "Оберіть файл іконки";
        openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        openFileDialog.Filter = "\"PNG файли (*.png)|*.png|Усі файли (*.*)|*.*\"";
        openFileDialog.Multiselect = false;

        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            string selectedFilePath = openFileDialog.FileName;

            pictureBoxPreviewIcon.Image = Image.FromFile(selectedFilePath);

            _selectedIcon = selectedFilePath;

            Console.WriteLine($"Обраний файл: {selectedFilePath}");
        }
        else
        {
            Console.WriteLine("Вибір файлу скасовано.");
        }
    }

    private void textBoxEnterName_TextChanged(object sender, EventArgs e)
    {
        TextBox nameTextBox = (TextBox)sender;
        _selectedName = nameTextBox.Text;
        labelPreviewName.Text = nameTextBox.Text;
    }

    private void checkedListBoxGenres_SelectedIndexChanged(object sender, EventArgs e)
    {
        List<string> selectedGenres = checkedListBoxGenres.CheckedItems.Cast<string>().ToList();
        _selectedGenres = selectedGenres;
        labelPreviewGenres.Text = $"Жанри: {string.Join(", ", selectedGenres)}";
    }

    private void buttonSave_Click(object sender, EventArgs e)
    {
        Playlist newPlaylist = new Playlist(_selectedName, _selectedIcon, _selectedGenres);
        _playlists.Add(newPlaylist);

        MessageBox.Show("Плейлист успішно додано!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);

        DialogResult = DialogResult.OK;
        Close();
    }

    private void buttonCancel_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
        Close();
    }
}
