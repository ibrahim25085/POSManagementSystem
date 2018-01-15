using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using POSEntity.Model.SetupFile;
using POSService;

namespace PointOfSaleManagementSystem.Controllers
{
    public class ExpenseItemController : Controller
    {
        ExpenseItemService ex = new ExpenseItemService();
        // GET: ExpenseItem
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(ExpenseItem item)
        {
            if(ModelState.IsValid)
            {
                ex.Insert(item);
            }
            return View();
        }
        public ActionResult Update(ExpenseItem item)
        {
            ex.Update(item);
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