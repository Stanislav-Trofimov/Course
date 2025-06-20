namespace Course.Global.Objects
{
    public interface ISong : IObject
    {
        public List<string> Artists { get; }
        //public TimeSpan Duration { get; }
        public string Lyrics { get; }
    }
}
