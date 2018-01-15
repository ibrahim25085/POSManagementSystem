using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using POSEntity.Model.SetupFile;
using POSService;

namespace PointOfSaleManagementSystem.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        CategoryService cat = new CategoryService();
        [HttpGet]
        public ActionResult Details(int ID)
        {
            Category category = cat.Get(ID);
            return View(category);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Category ctrg)
        {
            if (ModelState.IsValid) {
                cat.Insert(ctrg);
                RedirectToAction("GetAll");
            }
            return View();
        }
        public ActionResult Update(int ID)
        {
            Category category = cat.Get(ID);
            return View(category);
        }
        [HttpPost]
        public ActionResult Update(Category ctrg)
        {
            cat.Update(ctrg);
            return RedirectToAction("GetAll");
        }
        public ActionResult GetAll()
        {
            var category = cat.GetAll();
            return View(category);
        }
        [HttpGet]
        public ActionResult Delete(int ID)
        {
            cat.Delete(ID);
            return View();
        }
    }
}