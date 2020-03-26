using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Gym.Core.DbEntities;
using Gym.Core.Repositories;
using Gym.Core.ViewModels;

namespace Gym.Persistence.Repositories
{
    public class TraineeSubscriptionRepository : Repository<TraineeSubscription,int>, ITraineeSubscriptionRepository
    {
        public TraineeSubscriptionRepository(DbContext dbContext) : base(dbContext)
        {
        }
        

    }
}