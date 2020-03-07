using System;
using System.Collections.Generic;
using System.Text;

namespace PoseTrainerLibrary.Models
{
    public class Exercise
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Script { get; set; }
        public ICollection<History> Histories { get; set; }
    }
}
