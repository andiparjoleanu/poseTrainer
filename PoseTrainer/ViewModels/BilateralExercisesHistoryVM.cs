﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoseTrainer.ViewModels
{
    public class BilateralExercisesHistoryVM
    {
        public string UserId { get; set; }
        public string ExerciseId { get; set; }
        public int LeftSideReps { get; set; }
        public int RightSideReps { get; set; }
    }
}
