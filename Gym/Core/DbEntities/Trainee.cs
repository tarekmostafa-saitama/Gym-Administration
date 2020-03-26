using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gym.Core.DbEntities
{
    public class Trainee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public int AvgForm { get; set; }


        public  ICollection<TraineeSubscription> TraineeSubscriptions { get; set; }
        public  ICollection<WeightObservation> WeightObservations { get; set; }
    }
}