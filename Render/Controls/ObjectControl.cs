using Course.Directory.Objects;
using Course.Global.DataOperations;
using Course.Global.FileManagers;
using Course.Global.Objects;
using Course.Library.Objects;
using Course.Render.Forms;
using Course.Render.Forms.ItemDetails;
using System.ComponentModel;

namespace Course.Render.Controls;

public partial class ObjectControl : UserControl
{
    private DataFacade _facade;
    private IObject _objectData;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public IObject ObjectData
    {
        get => _objectData;
        set
        {
            _objectData = value;
            DisplayData();
        }
    }

    public ObjectControl(DataFacade facade)
    {
        _facade = facade;

        InitializeComponent();
    }

    private void DisplayData()
    {
        if (_objectData == null)
        {
            pictureBox.Image = null;
            labelName.Text = "Дані відсутні";
            return;
        }

        labelName.Text = _objectData.Name;

        string? pathToLoad = null;

        if (_objectData.Icon != null && File.Exists(_objectData.Icon))
        {
            pathToLoad = _objectData.Icon;
            Console.WriteLine($"Завантаження іконки для {_objectData.Name} зі збереженого шляху: {pathToLoad}");
        }
        else
        {
            pathToLoad = ImageManager.GetImagePath(_objectData.Id, _objectData.GetType().Name);
            Console.WriteLine($"Шлях з Icon порожній або файл не знайдено. Спроба завантажити за очікуваним шляхом: {pathToLoad}");
        }

        if (pathToLoad != null && File.Exists(pathToLoad))
        {
            try
            {
                pictureBox.Image = Image.FromFile(pathToLoad);

                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Помилка завантаження зображення для гурту {_objectData.Name} з шляху {pathToLoad}: {exception.Message}");
                pictureBox.Image = null;
            }
        }
        else
        {
            Console.WriteLine($"Зображення не знайдено для гурту {_objectData.Name} за жодним шляхом.");
            pictureBox.Image = null;
        }
    }

    private void pictureBox_Click(object sender, EventArgs e)
    {
        Form detailsForm = _objectData switch
        {
            Band band => new FormBandDetails(band, _facade),
            Album album => new FormAlbumDetails(album),
            Song song => new FormSongDetails(song),

            Playlist playlist => new FormPlaylistDetails(playlist, _facade),
            CustomSong customSong => new FormCustomSongDetails(customSong, _facade),

            _ => throw new NotImplementedException($"Не реалізовано відображення деталей для типу: {_objectData?.GetType().Name ?? "null"}")
        };

        detailsForm.Show();
    }
}
