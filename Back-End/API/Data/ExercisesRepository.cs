using API.Entities;
using API.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class ExercisesRepository : IExercisesRepository
    {
        private readonly DataContext _context;

        public ExercisesRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<Exercises> GetExercisesbyID(int id)
        {
            return await _context.Exercises
                .Include(p => p.Photo)
                .Include(w => w.Workouts)
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<Exercises>> GetAllExercises()
        {
            return await _context.Exercises
                .Include(p => p.Photo)
                .Include(w => w.Workouts)
                .ToListAsync();
        }

        public async Task<Exercises> GetExercisebyName(string name)
        {
            return await _context.Exercises
                .Include(p => p.Photo)
                .Include(w => w.Workouts)
                .FirstOrDefaultAsync(x => x.Name == name);
        }

        public void Update(Exercises exercise)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}
