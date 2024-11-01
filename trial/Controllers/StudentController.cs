using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using trial.Models;

namespace trial.Controllers
{
    public class StudentController : Controller
    {
        [HttpGet]
        public ActionResult Create()
        {
            //ViewBag.Name = Request["Name"];
            //ViewBag.Id = Request["Id"];
            return View(new Student());
        }
        [HttpPost]
        public ActionResult Create(Student s)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index", "Home");
            }
            return View(s);
        }
    }
}