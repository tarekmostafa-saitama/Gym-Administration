using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using Gym.Core;
using Gym.Core.DbEntities;
using Gym.Core.ViewModels;

namespace Gym.Controllers
{
    [Authorize]
    public class TraineeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public TraineeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        // GET: Trainees
        public ActionResult List()
        {
            var trainees = _unitOfWork.TraineeRepository.GetAll();
            return View(trainees);
        }
        // GET: Trainee
        public ActionResult Profile(int id)
        {
            var profileViewModel = new ProfileViewModel()
            {
                Trainee = _unitOfWork.TraineeRepository.Get(id),
                Subscriptions = _unitOfWork.TraineeSubscriptionRepository.Find(x => x.TraineeId == id).Select(result => new SubscriptionViewModel()
                    {
                        Id = result.Id,
                        Name = result.Subscription.Name,
                        Price = result.Subscription.Price,
                        AttendedAmount = result.TraineeSubscriptionsDetails.Count(),
                        StartDate = result.SubscriptionStartTime,
                        EndDate = result.SubscriptionEndTime,
                        SubscriptionAmount = result.Subscription.CourseAmount
                    })
                    .ToList().OrderByDescending(x=>x.Id).Take(10).ToList(),
                SubscriptionList = _unitOfWork.SubscriptionRepository.GetAll().Select(x=>new SubscriptionList{Id = x.Id,Name = x.Name}).ToList()
            };
            
            return View(profileViewModel);
        }
        public ActionResult AddSubscriptionToTrainee(int traineeId,int subscriptionList)
        {
            var subscription = new TraineeSubscription()
            {
                SubscriptionId = subscriptionList,
                TraineeId = traineeId,
                SubscriptionStartTime = DateTime.Now,
                SubscriptionEndTime = DateTime.Now.AddDays(30)
            };
            _unitOfWork.TraineeSubscriptionRepository.Add(subscription);
            _unitOfWork.Complete();

            return RedirectToAction("Profile",new{id = traineeId});
        }
        public ActionResult WeightGraphData(int id)
        {
            var graphData = _unitOfWork.TraineeRepository.Get(id).WeightObservations.Select(x=>new {Weight= x.Weight , Month = x.Month}).OrderBy(x=>x.Month).ToList();
          //  var json = new JavaScriptSerializer().Serialize(graphData);
            return Json(graphData,JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult AttachSubscriptionDetail(int traineeId,int subId)
        {
            var item = new TraineeSubscriptionsDetail()
            {
                SubscriptionDetailStartTime = DateTime.Now,
                TraineeSubscriptionId = subId
            };
            _unitOfWork.TraineeSubscriptionsDetailRepository.Add(item);
            _unitOfWork.Complete();
            return RedirectToAction("Profile", new { id = traineeId });
        }
        
        public ActionResult DeleteTraineeSubscription(int traineeId, int subId)
        {

            var subscription = _unitOfWork.TraineeSubscriptionRepository.Find(x =>
                x.TraineeId == traineeId && x.Id == subId).FirstOrDefault();
            _unitOfWork.TraineeSubscriptionRepository.Delete(subscription);
            _unitOfWork.Complete();
            return RedirectToAction("Profile", new { id = traineeId });
        }
        [HttpPost]
        public ActionResult GetSubscriptionDetail(int subId)
        {
            var model = _unitOfWork.TraineeSubscriptionsDetailRepository.Find(c=>c.TraineeSubscriptionId == subId);

            return PartialView("_PartialSubscriptionDetail",model);
        }
        [HttpPost]
        public ActionResult AddTrainee(Trainee trainee)
        {
            _unitOfWork.TraineeRepository.Add(trainee);
            _unitOfWork.Complete();
            return RedirectToAction("List");
        }
    }
}