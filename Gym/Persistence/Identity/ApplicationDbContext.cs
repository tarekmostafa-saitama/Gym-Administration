using System.Data.Entity;
using Gym.Core.DbEntities;

using Microsoft.AspNet.Identity.EntityFramework;

namespace Gym.Persistence.Identity
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Trainee> Trainees { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<TraineeSubscription> TraineeSubscriptions { get; set; }
        public DbSet<TraineeSubscriptionsDetail> TraineeSubscriptionsDetails { get; set; }
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            Database.SetInitializer<ApplicationDbContext>(new ApplicationDbInitializer());
        }

        static ApplicationDbContext()
        {

        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
            base.OnModelCreating(modelBuilder);

        }
    }
}
