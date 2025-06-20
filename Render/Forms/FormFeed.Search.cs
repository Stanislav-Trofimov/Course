using Course.Directory.Objects;
using Course.Global.Objects;
using Course.Render.Controls;
using Course.Systems.FilterSystem;
using Course.Systems.QueryGenerator;

namespace Course.Render;

public partial class FormFeed
{
    // Важливі, незмінні поля
    private Modifer _modifer = Modifer.All;
    private List<Filter> _filters = new List<Filter>();
    private List<ContentType> _types = new List<ContentType>();

    // Збір даних для фільтрів
    private List<string> _genres = new List<string>();

    // Фабрика
    private readonly FilterFactory _factory = new FilterFactory();

    private void PerformSearch(object? sender, EventArgs e)
    {
        string? queryText = textBoxSearch.Text.Trim();

        FilterCommand? command = null;

        if (_filters.Count > 0)
        {
            Dictionary<Filter, object> filtersData = new Dictionary<Filter, object>()
            {
                { Filter.Genres, _genres }
            };

            FilterCriteria filterCriteria = new FilterCriteria(_modifer, _filters, filtersData);
            command = new FilterCommand(_factory, filterCriteria);
        }
        
        InvokeCriteria invokeCriteria = new InvokeCriteria(queryText, _types);
        QueryGenerator queryGenerator = new QueryGenerator(_facade, command, invokeCriteria);

        SearchResult result = queryGenerator.Search();
        DisplaySearchData(result);
        buttonClearSearchResult.Visible = true;
    }

    private void DisplaySearchData(SearchResult result)
    {
        List<Band>? bands = result.Bands;
        List<Album>? albums = result.Albums;
        List<Song>? songs = result.Songs;

        BindingSearchData(flowLayoutBands, labelTitleBands, bands);
        BindingSearchData(flowLayoutAlbums, labelTitleAlbums, albums);
        BindingSearchData(flowLayoutSongs, labelTitleSongs, songs);
    }
    private void BindingSearchData<T>(FlowLayoutPanel panel, Label label, List<T>? objects) where T : DirectoryObject
    {
        panel.Controls.Clear();

        if (objects == null || objects.Count == 0)
        {
            label.Text = "Немає даних";
            return;
        }

        int itemsToDisplay = Math.Min(10, objects.Count);

        List<T> displayObjects = objects.Take(itemsToDisplay).ToList();

        foreach (T obj in displayObjects)
        {
            ObjectControl objectControl = new ObjectControl(_facade);

            objectControl.ObjectData = obj;

            panel.Controls.Add(objectControl);
        }
    }

    private void ChangeModifier(object sender, EventArgs e)
    {
        if (radioButtonAll.Checked)
            _modifer = Modifer.All;
        else if (radioButtonOr.Checked)
            _modifer = Modifer.Or;
        else if (radioButtonNot.Checked)
            _modifer = Modifer.Not;

        Console.WriteLine($"Ввімкнений {_modifer} модифікатор");
    }

    private void checkedListBoxGenres_ItemCheck(object sender, ItemCheckEventArgs e)
    {
        string? genre = checkedListBoxGenres.Items[e.Index].ToString();

        if (genre != null)
        {
            if (!_genres.Contains(genre))
            {
                _genres.Add(genre);
                Console.WriteLine($"Значення {genre} було додано до списку жанрів");
            }
            else if (_genres.Contains(genre))
            {
                _genres.Remove(genre);
                Console.WriteLine($"Значення {genre} було видалено з списку жанрів");
            }

            if (_genres.Count == 0 && _filters.Contains(Filter.Genres))
            {
                _filters.Remove(Filter.Genres);
                Console.WriteLine($"Фільтр Genres було видалено з списку фільтрів");
            }
            else if (_genres.Count > 0 && !_filters.Contains(Filter.Genres))
            {
                _filters.Add(Filter.Genres);
                Console.WriteLine($"Фільтр Genres було додано до списку фільтрів");
            }
        }
        else
        {
            throw new NullReferenceException($"Значення на позиції {e.Index} не існує.");
        }
    }

    private void ChangeTypeBands(object sender, EventArgs e) => ChangeType(sender, ContentType.Bands);

    private void ChangeTypeAlbums(object sender, EventArgs e) => ChangeType(sender, ContentType.Albums);

    private void ChangeTypeSongs(object sender, EventArgs e) => ChangeType(sender, ContentType.Songs);

    private void ChangeType(object sender, ContentType type)
    {
        CheckBox? check = sender as CheckBox;

        if (check != null)
        {
            if (check.Checked && !_types.Contains(type))
            {
                _types.Add(type);
                Console.WriteLine($"Ввімкнено пошук за {type}");
            }
            else if (!check.Checked && _types.Contains(type))
            {
                _types.Remove(type);
                Console.WriteLine($"Вимкнено пошук за {type}");
            }
        }
        else
        {
            throw new NullReferenceException($"Неправильний тип CheckBox для {type}");
        }
    }
}

