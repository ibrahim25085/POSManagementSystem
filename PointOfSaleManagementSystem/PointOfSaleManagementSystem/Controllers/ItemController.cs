using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using POSEntity.Model.SetupFile;
using POSService;

namespace PointOfSaleManagementSystem.Controllers
{
    public class ItemController : Controller
    {
        // GET: Item

        ItemService items = new ItemService();
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Item item)
        {
            if (ModelState.IsValid)
            {
                items.Insert(item);

            }
            return View();
        }
        public ActionResult Update(Item item)
        {
            items.Update(item);
            return View();
        }
        public ActionResult GetAll()
        {
            items.GetAll();
            return View();
        }
        public ActionResult Delete(int ID)
        {
            items.Delete(ID);
            return View();
        }
    }
}