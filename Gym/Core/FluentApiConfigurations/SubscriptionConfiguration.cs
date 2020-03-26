using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using Gym.Core.DbEntities;

namespace Gym.Core.FluentApiConfigurations
{
    public class SubscriptionConfiguration : EntityTypeConfiguration<Subscription>
    {
        public SubscriptionConfiguration()
        {
            HasKey(t => t.Id);

            HasMany(c => c.TraineeSubscriptions)
                .WithRequired()
                .HasForeignKey(c => c.SubscriptionId);
        }
    }
}