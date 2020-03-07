using System;
using System.Collections.Generic;
using System.Text;

namespace PoseTrainerLibrary.Models
{
    public class BilateralExercisesHistory
    {
        public string UserId { get; set; }
        public string ExerciseId { get; set; }
        public History History { get; set; }
        public int LeftSideReps { get; set; }
        public int RightSideReps { get; set; }
    }
}
