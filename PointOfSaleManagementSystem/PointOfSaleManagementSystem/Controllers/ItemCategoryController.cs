using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using POSEntity.Model.SetupFile;
using POSService;

namespace PointOfSaleManagementSystem.Controllers
{
    public class ItemCategoryController : Controller
    {
        // GET: ItemCategory
        ItemCategoryService item = new ItemCategoryService();
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(ItemCategory ctrg)
        {
            if (ModelState.IsValid)
            {
                item.Insert(ctrg);
            }
            return View();
        }
        public ActionResult Update(ItemCategory ctrg)
        {
            item.Update(ctrg);
            return View();
        }
        public ActionResult GetAll()
        {
            item.GetAll();
            return View();
        }
        public ActionResult Delete(int ID)
        {
            item.Delete(ID);
            return View();
        }
    }
}