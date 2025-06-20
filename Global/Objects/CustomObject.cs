using Newtonsoft.Json;

namespace Course.Global.Objects;

public abstract class CustomObject : IObject
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Icon { get; set; }
    public List<string> Genres { get; set; }

    [JsonConstructor]
    protected CustomObject(string id, string name, string icon, List<string> genres)
    {
        Id = id;
        Name = name;
        Icon = icon;
        Genres = genres;
    }

    public CustomObject(string name, string icon, List<string> genres)
    {
        Id = Guid.NewGuid().ToString();
        Name = name;
        Icon = icon;
        Genres = genres;
    }
}
