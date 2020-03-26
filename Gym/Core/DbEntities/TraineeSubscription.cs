using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gym.Core.DbEntities
{
    public class TraineeSubscription
    {
        public int Id { get; set; }
        public int SubscriptionId { get; set; }
        public int TraineeId { get; set; }
        public Subscription Subscription { get; set; }
        public Trainee Trainee { get; set; }

        public DateTime SubscriptionStartTime { get; set; }
        public DateTime SubscriptionEndTime { get; set; }
        public ICollection<TraineeSubscriptionsDetail> TraineeSubscriptionsDetails { get; set; }
    }
}