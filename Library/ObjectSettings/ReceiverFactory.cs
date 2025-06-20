using Course.Global.Objects;

namespace Course.Library.ObjectSettings;

class ReceiverFactory<TObject> where TObject : CustomObject
{
    private readonly static Dictionary<Settings, object> _settingsMap;

    static ReceiverFactory()
    {
        _settingsMap = new Dictionary<Settings, object>()
        {
            { Settings.Name, new NameReceiver<TObject>() },
            { Settings.Icon, new IconReceiver<TObject>() },
            { Settings.Genres, new GenresReceiver<TObject>() },

            { Settings.Artists, new ArtistsReceiver() },
            { Settings.Lyrics, new LyricsReceiver() },
            { Settings.AlbumName, new AlbumNameReceiver() },

            { Settings.AddSong, new AddSongReceiver() },
            { Settings.RemoveSong, new RemoveSongReceiver() }
        };
    }

    public IReceiver<TObject, TValue> GetStrategy<TValue>(Settings setting)
    {
        if (_settingsMap.TryGetValue(setting, out var objectReceiver))
        {
            IReceiver<TObject, TValue>? editReceiver = objectReceiver as IReceiver<TObject, TValue>;

            if (editReceiver is IReceiver<TObject, TValue> && editReceiver != null)
            {
                return editReceiver;
            }
            else
            {
                throw new InvalidOperationException($"Знайдено редактор для налаштування {setting}, але він має неправильний тип.");
            }
        }
        else
        {
            throw new ArgumentException($"Редактор налаштування {setting} для типу {typeof(TObject).Name} не зареєстрований у фабриці.");
        }
    }
}
