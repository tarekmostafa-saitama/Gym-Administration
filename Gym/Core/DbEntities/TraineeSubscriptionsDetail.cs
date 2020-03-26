using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gym.Core.DbEntities
{
    public class TraineeSubscriptionsDetail
    {
        public int Id { get; set; }
        public DateTime SubscriptionDetailStartTime { get; set; }
        public int TraineeSubscriptionId { get; set; }
        public TraineeSubscription TraineeSubscription { get; set; }
    }
}