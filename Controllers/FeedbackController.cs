using StudentFeedbackMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentFeedbackMVC.Controllers
{
    public class FeedbackController : Controller
    {
        static List<Feedback> feedbacklist = new List<Feedback>();

        // GET: Feedback
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Feedback f1)
        {
            feedbacklist.Add(f1);
            return RedirectToAction("List");
        }

        [HttpGet]
        public ActionResult List()
        {
            return View(feedbacklist);
        }
    }
}