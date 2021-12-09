using API.Entities;
using API.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class WorkoutsRepository : IWorkoutRepository
    {
        private readonly DataContext _context;

        public WorkoutsRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Workouts>> GetAllWorkouts()
        {
            return await _context.Workouts
                .Include(e => e.Exercises)
                .Include(u => u.UserId)
                .ToListAsync();
        }

        public async Task<Workouts> GetWorkoutbyName(string name)
        {
            return await _context.Workouts
                .Include(e => e.Exercises)
                .Include(u => u.UserId)
                .FirstOrDefaultAsync(x => x.Name == name);
        }

        public async Task<Workouts> GetWorkoutsbyId(int id)
        {
            return await _context.Workouts
                .Include(e => e.Exercises)
                .Include(u => u.UserId)
                .FirstOrDefaultAsync(x => x.Id == id);

        }
    }
}
