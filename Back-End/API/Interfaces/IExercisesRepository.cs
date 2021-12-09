using API.Entities;

namespace API.Interfaces
{
    public interface IExercisesRepository
    {
        Task<Exercises> GetExercisesbyID(int id);

        Task<IEnumerable<Exercises>> GetAllExercises();

        Task<Exercises> GetExercisebyName(string name);
        void Update(Exercises exercise);
        Task<bool> SaveAllAsync();
    }
}
