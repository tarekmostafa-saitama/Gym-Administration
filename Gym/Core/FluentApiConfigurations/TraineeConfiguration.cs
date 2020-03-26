using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using Gym.Core.DbEntities;

namespace Gym.Core.FluentApiConfigurations
{
    public class TraineeConfiguration : EntityTypeConfiguration<Trainee>
    {
        public TraineeConfiguration()
        {
            HasKey(t => t.Id);

            HasMany(c => c.TraineeSubscriptions)
                .WithRequired()
                .HasForeignKey(c => c.TraineeId);

            HasMany(c => c.WeightObservations)
                .WithRequired()
                .HasForeignKey(c => c.TraineeId);
        }
    }
}