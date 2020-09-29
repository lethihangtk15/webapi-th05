using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TH05.Models;

namespace TH05.Controllers
{
    public class HomeController : Controller
    {
        public StudentsController st = new StudentsController();
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult student()
        {
            ViewBag.Title = "Home Page";

            return View(st.GetStudents());
        }
        public ActionResult ADD(string id, string first, string last, string stan)
        {
            StudentsController sv = new StudentsController();
            Student item = new Student();
            item.StudentID = id;
            item.FirstName = first;
            item.LastName = last;
            item.StandardId = stan;
            sv.PostStudent(item);
            
            return Redirect("~/Home/Student");
        }
    }
}
