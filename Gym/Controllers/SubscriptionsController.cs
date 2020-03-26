using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gym.Core;
using Gym.Core.DbEntities;

namespace Gym.Controllers
{
    [Authorize]
    public class SubscriptionsController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public SubscriptionsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        // GET: Subscriptions
        public ActionResult List()
        {
            var result = _unitOfWork.SubscriptionRepository.GetAll();
            return View(result);
        }
        [HttpPost]
        public ActionResult AddSubscription(Subscription subscription)
        {
            _unitOfWork.SubscriptionRepository.Add(subscription);
            _unitOfWork.Complete();
            return RedirectToAction("List");
        }
    }
}