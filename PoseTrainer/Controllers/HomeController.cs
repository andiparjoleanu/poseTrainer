using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
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
                     Type = exercise.Type,
                     Name = exercise.Name,
                     Script = exercise.Script
                });
            }

            return exerciseVMs;
        }

        [HttpPost("SaveRepsUnilateral")]
        public async Task<ResultVM> SaveRepsUnilateral(object reps)
        {
            try
            {
                var model = JsonConvert.DeserializeObject<UnilateralExercisesHistoryVM>(reps.ToString());
                History history = new History
                {
                    ExerciseId = model.ExerciseId,
                    Date = DateTime.Now,
                    UserId = model.UserId
                };

                await _repositoryWrapper.HistoryRepository.CreateAsync(history);

                UnilateralExercisesHistory unilateralHistory = new UnilateralExercisesHistory
                {
                    ExerciseId = model.ExerciseId,
                    UserId = model.UserId,
                    Reps = model.Reps
                };

                await _repositoryWrapper.UnilateralExercisesHistoryRepository.CreateAsync(unilateralHistory);

            }
            catch(Exception ex)
            {
                return new ResultVM
                {
                    Status = Status.Error,
                    Message = ex.Message
                };
            }

            return new ResultVM
            {
                Status = Status.Success,
                Message = "Numărul de repetări a fost memorat în Baza de Date"
            };
        }

        [HttpPost("SaveRepsBilateral")]
        public async Task<ResultVM> SaveRepsBilateral(object reps)
        {
            try
            {
                var model = JsonConvert.DeserializeObject<BilateralExercisesHistoryVM>(reps.ToString());
                History history = new History
                {
                    ExerciseId = model.ExerciseId,
                    Date = DateTime.Now,
                    UserId = model.UserId
                };

                await _repositoryWrapper.HistoryRepository.CreateAsync(history);

                BilateralExercisesHistory bilateralHistory = new BilateralExercisesHistory
                {
                    ExerciseId = model.ExerciseId,
                    UserId = model.UserId,
                    LeftSideReps = model.LeftSideReps,
                    RightSideReps = model.RightSideReps
                };

                await _repositoryWrapper.BilateralExercisesHistoryRepository.CreateAsync(bilateralHistory);

            }
            catch (Exception ex)
            {
                return new ResultVM
                {
                    Status = Status.Error,
                    Message = ex.Message
                };
            }

            return new ResultVM
            {
                Status = Status.Success,
                Message = "Numărul de repetări a fost memorat în Baza de Date"
            };
        }
    }
}