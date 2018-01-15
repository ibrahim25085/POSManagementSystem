using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using POSEntity.Model.SetupFile;
using POSService;

namespace PointOfSaleManagementSystem.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        EmployeeService emp = new EmployeeService();
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee employees)
        {
            if (ModelState.IsValid)
            {
                emp.Insert(employees);
                return View();
            }

            return View();
        }
        public ActionResult Update(Employee employees)
        {
            emp.Insert(employees);
            return View();
        }
        public ActionResult GetAll()
        {
            emp.GetAll();
            return View();
        }
        public ActionResult Delete(int ID)
        {
            emp.Delete(ID);
            return View();
        }
    }
}