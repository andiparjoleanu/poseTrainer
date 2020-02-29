using PoseTrainerLibrary.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace PoseTrainerLibrary
{
    public interface IRepositoryWrapper
    {
        IExerciseRepository ExerciseRepository { get; }
        IHistoryRepository HistoryRepository { get; }
    }
}
