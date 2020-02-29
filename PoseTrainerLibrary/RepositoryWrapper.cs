using PoseTrainerLibrary.Context;
using PoseTrainerLibrary.IRepositories;
using PoseTrainerLibrary.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace PoseTrainerLibrary
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private PoseTrainerDbContext _context;
        private IExerciseRepository _exercise;
        private IHistoryRepository _history;

        public IExerciseRepository ExerciseRepository
        {
            get
            {
                if(_exercise == null)
                {
                    _exercise = new ExerciseRepository(_context);
                }

                return _exercise;
            }
        }

        public IHistoryRepository HistoryRepository
        { 
            get
            {
                if(_history == null)
                {
                    _history = new HistoryRepository(_context);
                }

                return _history;
            }
        }

        public RepositoryWrapper(PoseTrainerDbContext context)
        {
            _context = context;
        }
    }
}
