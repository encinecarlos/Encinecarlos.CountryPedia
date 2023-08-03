namespace Encinecarlos.CountryPedia.Domain.Entities
{
    public class Country
    {
        public Name name { get; set; }
        public string[] tld { get; set; }
        public string cca2 { get; set; }
        public string ccn3 { get; set; }
        public string cca3 { get; set; }
        public string cioc { get; set; }
        public bool independent { get; set; }
        public string status { get; set; }
        public bool unMember { get; set; }
        public Currencies currencies { get; set; }
        public Idd idd { get; set; }
        public string[]? capital { get; set; }
        public string[]? altSpellings { get; set; }
        public string region { get; set; }
        public string subregion { get; set; }
        public Languages languages { get; set; }
        public Translations translations { get; set; }
        public float[] latlng { get; set; }
        public bool landlocked { get; set; }
        public float area { get; set; }
        public Demonyms demonyms { get; set; }
        public string flag { get; set; }
        public Maps maps { get; set; }
        public int population { get; set; }
        public string fifa { get; set; }
        public Car car { get; set; }
        public string[] timezones { get; set; }
        public string[] continents { get; set; }
        public Flags flags { get; set; }
        public Coatofarms coatOfArms { get; set; }
        public string startOfWeek { get; set; }
        public Capitalinfo capitalInfo { get; set; }
    }
}
