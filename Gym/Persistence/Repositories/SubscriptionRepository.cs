using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Gym.Core.DbEntities;
using Gym.Core.Repositories;
using Gym.Core.ViewModels;
using Gym.Persistence.Identity;

namespace Gym.Persistence.Repositories
{
    public class SubscriptionRepository : Repository<Subscription,int>, ISubscriptionRepository
    {
        private readonly ApplicationDbContext _context;
        public SubscriptionRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }


    }
}