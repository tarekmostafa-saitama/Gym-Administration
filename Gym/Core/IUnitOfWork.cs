using Gym.Core.Repositories;
using Gym.Persistence.Repositories;

namespace Gym.Core
{
    public interface IUnitOfWork
    {
         ITraineeRepository TraineeRepository { get; set; }
         ISubscriptionRepository SubscriptionRepository { get; set; }
         ITraineeSubscriptionsDetailRepository TraineeSubscriptionsDetailRepository { get; set; }
         ITraineeSubscriptionRepository TraineeSubscriptionRepository { get; set; }
        int Complete();
        void Dispose();
    }
}