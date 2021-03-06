﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using Gym.Core.DbEntities;

namespace Gym.Core.FluentApiConfigurations
{
    public class WeightObservationConfiguration : EntityTypeConfiguration<WeightObservation>
    {
        public WeightObservationConfiguration()
        {
            HasKey(c => c.Id);
        }
    }
}