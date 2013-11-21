namespace Trade.Model
{
    public class QuoteCard
    {
        public QuoteCard() { }

        public QuoteCard(string[] value, int version, bool full)
        {
            this.Value = value;
            this.Version = version;
            this.FullData = full;
        }

        public string Error { get; set; }
        public string[] Value { get; set; }
        public int Version { get; set; }
        public bool FullData { get; set; }
    }
}