using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using semana_11_02.Models;
using semana_11_02.Repository;

namespace semana_11_02.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult GetAllEmpDetails()
        {
            Emprepository Emprepo = new Emprepository();
            ModelState.Clear();

            return View(Emprepo.GetAllEmployee());
        }

        public ActionResult AddEmployee()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddEmployee(EmpModel emp)
        {
            try
            {
                Emprepository Emprepo = new Emprepository();
                if (Emprepo.AddEmployee(emp))
                {
                    ViewBag.message = "Almacenado correctamente";
                }
                return RedirectToAction("GetAllEmpDetails");
            }
            catch (Exception)
            {
                return View();
            }
        }

        public ActionResult EditEmployeeDetails(int id)
        {
            Emprepository Emprepo = new Emprepository();
            return View(Emprepo.GetAllEmployee().Find(Emp => Emp.Empid == id));
        }

        [HttpPost]
        public ActionResult EditEmployeeDetails(EmpModel emp)
        {
            try
            {
                Emprepository Emprepo = new Emprepository();
                Emprepo.UpdateEmployee(emp);
                return RedirectToAction("GetAllEmpDetails");
            }
            catch (Exception)
            {
                return View();
            }
        }

        [HttpPost]
        public ActionResult DeleteEmployee(int id)
        {
            try
            {
                Emprepository Emprepo = new Emprepository();
                if (Emprepo.DeleteEmployee(id))
                {
                    ViewBag.message = "Empleado correctamente";
                }
                return RedirectToAction("GetAllEmpDetails");
            }
            catch (Exception)
            {
                return View();
            }
        }
    }
}