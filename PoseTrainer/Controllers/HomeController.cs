using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PoseTrainer.ViewModels;
using PoseTrainerLibrary;
using PoseTrainerLibrary.Models;

namespace PoseTrainer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IRepositoryWrapper _repositoryWrapper;

        public HomeController(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        [HttpGet("getAllExercises")]
        public async Task<List<ExerciseVM>> GetAllExercises()
        {
            List<Exercise> exercises =  await _repositoryWrapper.ExerciseRepository.GetAllAsync();

            List<ExerciseVM> exerciseVMs = new List<ExerciseVM>();

            foreach(var exercise in exercises)
            {
                exerciseVMs.Add(new ExerciseVM
                {
                     Id = exercise.Id,
                     Difficulty = exercise.Difficulty,
                     Name = exercise.Name,
                     Script = exercise.Script
                });
            }

            return exerciseVMs;
        }
    }
}