namespace dotnetapp.Entities
{
    public class Visit
    {
        public int id { get; set; }
        public int location { get; set; }
        public int user { get; set; }
        public long visited_at { get; set; }
        public int mark { get; set; }
    }

    public class VisitArr
    {
        public Visit[] visits { get; set; }
    }
}