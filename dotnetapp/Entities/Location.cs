namespace dotnetapp.Entities
{
    public class Location
    {
        public int id { get; set; }
        public string place { get; set; }
        public string country { get; set; }
        public string city { get; set; }
        public int distance { get; set; }
    }

    public class LocArr
    {
        public Location[] locations { get; set; }
    }
}