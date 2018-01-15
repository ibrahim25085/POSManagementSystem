using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using POSEntity.Model.SetupFile;
using POSService;

namespace PointOfSaleManagementSystem.Controllers
{
    public class ExpenseCategoryController : Controller
    {
        // GET: ExpenseCategory
        ExpenseCategoryService ex = new ExpenseCategoryService();
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(ExpenseCategory ctrg)
        {
            if (ModelState.IsValid)
            {
                ex.Insert(ctrg);
            }
            return View();
        }
        public ActionResult Update(ExpenseCategory ctrg)
        {
            ex.Update(ctrg);
            return View();
        }
        public ActionResult GetAll()
        {
            ex.GetAll();
            return View();
        }
        public ActionResult Delete(int ID)
        {
            ex.Delete(ID);
            return View();
        }
    }
}