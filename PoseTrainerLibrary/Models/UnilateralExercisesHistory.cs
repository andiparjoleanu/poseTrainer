using System;
using System.Collections.Generic;
using System.Text;

namespace PoseTrainerLibrary.Models
{
    public class UnilateralExercisesHistory
    {
        public string UserId { get; set; }
        public string ExerciseId { get; set; }
        public History History { get; set; }
        public int Reps { get; set; }
    }
}
