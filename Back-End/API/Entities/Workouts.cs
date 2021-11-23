namespace API.Entities
{
    public class Workouts
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public AppUser UserId { get; set; }

        public Exercises Exercises { get; set; }

        public TimeOnly Time { get; set; }

        public DateTime Date { get; set; }

    }
}
