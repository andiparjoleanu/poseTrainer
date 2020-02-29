using PoseTrainerLibrary.Context;
using PoseTrainerLibrary.IRepositories;
using PoseTrainerLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PoseTrainerLibrary.Repositories
{
    public class HistoryRepository : BaseRepository<History>, IHistoryRepository   
    {
        public HistoryRepository(PoseTrainerDbContext context) : base(context) { }
    }
}
