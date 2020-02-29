using PoseTrainerLibrary.Context;
using PoseTrainerLibrary.IRepositories;
using PoseTrainerLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PoseTrainerLibrary.Repositories
{
    public class ExerciseRepository : BaseRepository<Exercise>, IExerciseRepository
    {
        public ExerciseRepository(PoseTrainerDbContext context) : base(context) { }
    }
}
