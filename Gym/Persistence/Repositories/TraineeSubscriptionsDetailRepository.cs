using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Gym.Core.DbEntities;
using Gym.Core.Repositories;
using Gym.Persistence.Identity;

namespace Gym.Persistence.Repositories
{
    public class TraineeSubscriptionsDetailRepository :Repository<TraineeSubscriptionsDetail,int>, ITraineeSubscriptionsDetailRepository
    {
        private readonly ApplicationDbContext _context;
        public TraineeSubscriptionsDetailRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

    }
}