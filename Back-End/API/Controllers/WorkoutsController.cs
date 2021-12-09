using API.Interfaces;
using Microsoft.AspNetCore.Mvc;
using API.Entities;
using Microsoft.AspNetCore.Authorization;

namespace API.Controllers
{
    public class WorkoutsController : BaseAPIController
    {
            private readonly IWorkoutRepository _WorkoutRepository;

            public WorkoutsController(IWorkoutRepository workoutRepository)
            {
                    _WorkoutRepository = workoutRepository;
            }


            [HttpGet]
            public async Task<IEnumerable<Workouts>> GetWorkouts()
            {
            return await _WorkoutRepository.GetAllWorkouts();
            }

            [Authorize]
            [HttpGet("{id}")]
            public async Task<ActionResult<Workouts>> GetWorkoutbyID(int id)
            {
                return await _WorkoutRepository.GetWorkoutsbyId(id);
            }

            [Authorize]
            [HttpGet("{name}")]
            public async Task<ActionResult<Workouts>> GetWorkoutByName(string name)
            {
                return await _WorkoutRepository.GetWorkoutbyName(name);
            }
        
    }
}