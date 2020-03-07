using PoseTrainerLibrary.Context;
using PoseTrainerLibrary.IRepositories;
using PoseTrainerLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PoseTrainerLibrary.Repositories
{
    public class UnilateralExercisesHistoryRepository : BaseRepository<UnilateralExercisesHistory>, IUnilateralExercisesHistoryRepository
    {
        public UnilateralExercisesHistoryRepository(PoseTrainerDbContext context) : base(context) { }
    }
}
