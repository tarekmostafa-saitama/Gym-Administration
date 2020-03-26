using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using Gym.Core.DbEntities;

namespace Gym.Core.FluentApiConfigurations
{
    public class TraineeSubscriptionConfiguration :EntityTypeConfiguration<TraineeSubscription>
    {
        public TraineeSubscriptionConfiguration()
        {
            HasKey(c => c.Id);
            HasMany(c=>c.TraineeSubscriptionsDetails).WithRequired(t=>t.TraineeSubscription)
                .HasForeignKey(c=>c.TraineeSubscriptionId).WillCascadeOnDelete(true);
        }
    }
}