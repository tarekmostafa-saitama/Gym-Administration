﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gym.Core.DbEntities
{
    public class WeightObservation
    {
        public int Id { get; set; }
        public int Weight { get; set; }
        public int Month { get; set; }
        public int TraineeId { get; set; }
        public Trainee Trainee { get; set; }
    }
}