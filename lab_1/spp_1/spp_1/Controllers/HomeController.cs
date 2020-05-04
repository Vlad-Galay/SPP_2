using spp_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace spp_1.Controllers
{
    public class HomeController : Controller
    {
        TaskContext db = new TaskContext();
        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult ShowTasks()
        {
            var tasks = db.Tasks;
            ViewBag.Tasks = tasks;
            return View(tasks);
        }

        [HttpGet]
        public ActionResult AddTask()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddTask(Task task)
        {
            db.Tasks.Add(task);
            db.SaveChanges();

            return RedirectToAction("ShowTasks");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}