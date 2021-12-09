using API.Entities;

namespace API.DTOs
{
    public class MemberDTO
    {

        public int Id { get; set; }

        public string Username { get; set; }

        public DateTime Created { get; set; } = DateTime.Now;

        public IList<Workouts> Workouts { get; set; }

    }
}
