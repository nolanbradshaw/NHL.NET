namespace NHL.NET.Models.Conference
{
    public class NHLConference
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Abbreviation { get; set; }

        public string ShortName { get; set; }

        public bool Active { get; set; }
    }
}
