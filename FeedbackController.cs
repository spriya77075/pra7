using Microsoft.AspNetCore.Mvc;
using FeedbackManagement.Models;

namespace FeedbackManagement.Controllers
{
    public class FeedbackController : Controller
    {
        private static List<Feedback> feedbackList = new();

        public IActionResult Index()
        {
            ViewBag.FeedbackList = feedbackList;
            return View(new Feedback());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                feedbackList.Add(feedback);
                ViewBag.Success = "Feedback submitted successfully!";
                ModelState.Clear();
                feedback = new Feedback();
            }

            ViewBag.FeedbackList = feedbackList;
            return View(feedback);
        }
    }
}