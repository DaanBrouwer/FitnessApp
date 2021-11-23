namespace API.Entities
{
    public class Exercises
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Muscle { get; set; }

        public ICollection<Workouts> Workouts { get; set; }

        public ICollection<Photo> Photo { get; set; }
    }
}
