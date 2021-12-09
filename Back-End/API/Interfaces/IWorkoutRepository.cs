using API.Entities;

namespace API.Interfaces
{
    public interface IWorkoutRepository
    {
        public Task<Workouts> GetWorkoutsbyId(int id);

        public Task<IEnumerable<Workouts>> GetAllWorkouts();

        public Task<Workouts> GetWorkoutbyName(string name);
    }
}
