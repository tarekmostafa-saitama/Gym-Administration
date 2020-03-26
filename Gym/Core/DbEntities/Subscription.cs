using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gym.Core.DbEntities
{
    public class Subscription
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int CourseAmount { get; set; }

        public ICollection<TraineeSubscription> TraineeSubscriptions { get; set; }
    }
}