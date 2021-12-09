namespace API.DTOs
{
    public class ExerciseDTO
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public string Muscle { get; set; }

        public ICollection<WorkoutDTO> Workouts { get; set; }

        public ICollection<PhotoDTO> Photo { get; set; }
    }
}
