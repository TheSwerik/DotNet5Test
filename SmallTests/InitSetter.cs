namespace SmallTests
{
    public struct InitSetter
    {
        public string Ass { get; init; }
    }
    public readonly struct NoSetter
    {
        public string Ass { get;  }

        public NoSetter(string ass)
        {
            Ass = ass;
        }
        
    }
}