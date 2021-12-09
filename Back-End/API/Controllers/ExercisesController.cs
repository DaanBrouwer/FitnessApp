using API.DTOs;
using API.Entities;
using API.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class ExercisesController : BaseAPIController
    {
        private readonly IExercisesRepository _exerciseRepository;
        private readonly IMapper mapper;

        public ExercisesController(IExercisesRepository exerciseRepository, IMapper mapper)
        {
            _exerciseRepository = exerciseRepository;
            this.mapper = mapper;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Exercises>>> GetExercises()
        {
            var exercises = await _exerciseRepository.GetAllExercises();
            var exercisesToReturn = this.mapper.Map<IEnumerable<ExerciseDTO>>(exercises);


            return Ok(exercisesToReturn);
        }

        [Authorize]
        [HttpGet("{id}")]
        public async Task<ActionResult<Exercises>> GetExercises(int id)
        {
            return await _exerciseRepository.GetExercisesbyID(id);
        }

        [Authorize]
        [HttpGet("/{name}")]
        public async Task<ActionResult<Exercises>> GetExercises(string name)
        {
            return await _exerciseRepository.GetExercisebyName(name);
        }

        [Authorize]
        [HttpPut("/{id}")]
        public async Task<ActionResult> UpdateExercises(ExerciseUpdateDTO exercises)
        {
            var exercise = await _exerciseRepository.GetExercisebyName(exercises.Name);

            this.mapper.Map(exercises, exercise);

            _exerciseRepository.Update(exercise);

            if (await _exerciseRepository.SaveAllAsync()) return NoContent();

            return BadRequest("Failed to update exercise");
        }

    }
}
