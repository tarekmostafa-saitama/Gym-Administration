using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gym.Core;
using Gym.Core.ViewModels;

namespace Gym.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new HomeViewModel()
            {
                SubscriptionsCount = _unitOfWork.SubscriptionRepository.Count(),
                TraineeCount = _unitOfWork.TraineeRepository.Count()
            };
            return View(model);
        }
        private readonly IUnitOfWork _unitOfWork;
        public HomeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}