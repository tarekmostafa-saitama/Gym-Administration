using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Gym.Core.DbEntities;

namespace Gym.Core.ViewModels
{
    public class SubscriptionViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AttendedAmount { get; set; }
        public int SubscriptionAmount { get; set; }
        public int Price { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }

    public class SubscriptionList
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class ProfileViewModel
    {
        public Trainee Trainee { get; set; }
        public ICollection<SubscriptionViewModel> Subscriptions { get; set; }
        public ICollection<SubscriptionList> SubscriptionList { get; set; }
    }
}