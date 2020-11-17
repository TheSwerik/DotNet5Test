namespace TestRecords
{
    public record RecordPositional(string Name, int Age);

    public record RecordPositionalChild(string Name, int Age) : RecordPositional(Name, Age);

    public record Record
    {
        public string Name { get; set; }
        public int Age { get; init; }
    }

    public record RecordChild : Record
    {
    }
}