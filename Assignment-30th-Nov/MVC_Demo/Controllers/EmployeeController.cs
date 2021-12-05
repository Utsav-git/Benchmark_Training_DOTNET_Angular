using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Demo.ViewModel;
using MVC_Demo.BAL;

namespace MVC_Demo.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeBAL b = new EmployeeBAL();

        // GET: Employee
        public ActionResult Index()
        {
            List<EmployeeVM> elist = b.GetEmpList();
            return View(elist);
        }

        [HttpGet]
        public ActionResult InsertEmployee() {
            return View();
        }

        [HttpPost]
        public ActionResult InsertEmployee(FormCollection fc)
        {
            /*if(ModelState.IsValid){*/

            try
            {
                EmployeeVM e = new EmployeeVM();
                e.emp_No = Convert.ToInt32(fc["emp_No"].ToString());
                e.emp_Name = fc["emp_Name"].ToString();
                e.salary = Convert.ToInt32(fc["salary"].ToString());
                e.designation = fc["designation"].ToString();
                e.dept_No = Convert.ToInt32(fc["dept_No"].ToString());

                b.InsertEmployee(e);

                return RedirectToAction("Index");
            }
            catch (Exception ex) {
                TempData["err"] = ex.Message;
                TempData["backpage"] = "InsertEmployee";
                return RedirectToAction("ErrorPage");
            }
            //}
        }
        [HttpGet]
        public ActionResult UpdateEmployee(int emp_No) {
            EmployeeVM e = b.GetEmpUsingEmpNo(emp_No);
            return View(e);
        }

        [HttpPost]
        public ActionResult UpdateEmployee(FormCollection fc)
        {
            try {
                EmployeeVM e = new EmployeeVM();
                e.emp_No = Convert.ToInt32(fc["emp_No"].ToString());
                e.emp_Name = fc["emp_Name"].ToString();
                e.salary = Convert.ToInt32(fc["salary"].ToString());
                e.designation = fc["designation"].ToString();
                e.dept_No = Convert.ToInt32(fc["dept_No"].ToString());

                b.UpdateEmployee(e);

                return RedirectToAction("Index");
            }
            catch (Exception ex) {
                TempData["err"] = ex.Message;
                TempData["backpage"] = "Index";
                return RedirectToAction("ErrorPage");
            }
        }
        
        [HttpGet]
        public ActionResult DetailsEmployee(int emp_No)
        {
            EmployeeVM e = b.GetEmpUsingEmpNo(emp_No);
            return View(e);
        }


        [HttpGet]
        public ActionResult ErrorPage() {
            TempData.Keep("err");
            TempData.Keep("backpage");

            return View();
        }

        /*[HttpGet]
        public ActionResult DeleteEmployee(int emp_No)
        {
            try {
                b.DeleteEmp(emp_No);
                return RedirectToAction("Index");
            }
            catch (Exception ex) { 
                TempData
            }

        }*/
    }
}