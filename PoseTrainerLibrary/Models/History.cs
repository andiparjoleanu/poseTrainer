﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PoseTrainerLibrary.Models
{
    public class History
    {
        public string UserId { get; set; }
        public virtual User User { get; set; }
        public string ExerciseId { get; set; }
        public virtual Exercise Exercise { get; set; }
        public DateTime Date { get; set; }
        public UnilateralExercisesHistory UnilateralExercisesHistory { get; set; }
        public BilateralExercisesHistory BilateralExercisesHistory { get; set; }
    }
}
