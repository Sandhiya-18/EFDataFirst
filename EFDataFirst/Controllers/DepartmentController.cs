using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EFDataFirst.Controllers
{
    public class DepartmentController : Controller
    {

        EFDataFirstEntities db = new EFDataFirstEntities();
        // GET: Department
        public ActionResult Index()
        {
            return View(db.Departments.ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View(new Department());
        }
        [HttpPost]
        public ActionResult Create(Department department)
        {
            if(ModelState.IsValid)
            {
                db.Departments.Add(department);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            else
            {
                return View(department);
            }
        }


    }
}