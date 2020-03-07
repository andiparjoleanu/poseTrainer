using PoseTrainerLibrary.Context;
using PoseTrainerLibrary.IRepositories;
using PoseTrainerLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PoseTrainerLibrary.Repositories
{
    public class BilateralExercisesHistoryRepository : BaseRepository<BilateralExercisesHistory>, IBilateralExercisesHistoryRepository
    {
        public BilateralExercisesHistoryRepository(PoseTrainerDbContext context) : base(context) { }
    }
}
