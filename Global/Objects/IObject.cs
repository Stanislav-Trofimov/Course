namespace Course.Global.Objects
{
    public interface IObject
    {
        public string Id { get; }
        public string Name { get; }
        public string Icon { get; }
        public List<string> Genres { get; }
    }
}
