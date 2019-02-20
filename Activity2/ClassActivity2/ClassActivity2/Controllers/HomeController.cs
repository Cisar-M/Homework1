using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClassActivity2.Models;
using System.Data;
using System.IO;
using ClassActivity2.ViewModel;

namespace ClassActivity2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
       

        [HttpGet]
        public ActionResult EmployeeReport()
        {
            ReportViewModel vm = new ReportViewModel();

            vm.Employees = GetEmployee(0);

            vm.DateFrom = new DateTime(2012,12,1);
            vm.DateTo = new DateTime(2013, 12, 31);

           return View(vm);

        }
        private SelectList GetEmployee(int selected)
        {
            using (HardwareDBEntities db = new HardwareDBEntities())
            {
                db.Configuration.ProxyCreationEnabled = false;

                var employees = db.lgemployees.Select(x => new SelectListItem
                {
                    Value = x.emp_num.ToString(),
                    Text = x.emp_fname
                }).ToList();
                if (selected == 0)
                    return new SelectList(employees, "Value", "Text");
                else
                    return new SelectList(employees, "Value", "Text",selected);
            }
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}