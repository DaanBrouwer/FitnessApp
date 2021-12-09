namespace API.DTOs
{
    public class WorkoutDTO
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public UserDto UserId { get; set; }

        public ExerciseDTO Exercises { get; set; }

        public TimeOnly Time { get; set; }

        public DateTime Date { get; set; }
    }
}
