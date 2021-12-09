namespace API.DTOs
{
    public class PhotoDTO
    {

        public int Id { get; set; }
        public string Url { get; set; }

        public bool IsMain { get; set; }

        public ExerciseDTO Exercises { get; set; }

        public UserDto AppUser { get; set; }

        public int AppUserId { get; set; }
    }
}
