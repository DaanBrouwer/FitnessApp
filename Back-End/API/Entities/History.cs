namespace API.Entities
{
    public class History
    {
        public int id { get; set; }
        public IList<Workouts> Workouts{ get; set; }
    }
}
