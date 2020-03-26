using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Gym.Core;
using Gym.Core.Repositories;
using Gym.Models;
using Gym.Persistence.Identity;
using Gym.Persistence.Repositories;

namespace Gym.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public ITraineeRepository TraineeRepository { get; set; }
        public ISubscriptionRepository SubscriptionRepository { get; set; }
        public ITraineeSubscriptionsDetailRepository TraineeSubscriptionsDetailRepository  { get; set; }
        public ITraineeSubscriptionRepository TraineeSubscriptionRepository { get; set; }
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            TraineeRepository = new TraineeRepository(context);
            SubscriptionRepository = new SubscriptionRepository(context);
            TraineeSubscriptionRepository = new TraineeSubscriptionRepository(context);
            TraineeSubscriptionsDetailRepository = new TraineeSubscriptionsDetailRepository(context);
        }
        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}