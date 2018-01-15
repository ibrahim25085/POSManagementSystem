using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using POSEntity.Model.SetupFile;
using POSService;

namespace PointOfSaleManagementSystem.Controllers
{
    public class PurchaseController : Controller
    {
        ItemCategoryService data = new ItemCategoryService();
        // GET: Purchase
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ItemCategory item)
        {
            if (ModelState.IsValid)
            {

            }
               var isAdded = data.Insert(item)>0;
                if(isAdded)
                {
                    return View(item);
                }
               

     
            return View();
        }
    }
}