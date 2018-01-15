using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using POSEntity.Model.SetupFile;
using POSService;

namespace PointOfSaleManagementSystem.Controllers
{
    public class OutletController : Controller
    {
        // GET: Outlet
        OutletService outl=new OutletService();
       
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Outlet outlet)
        {
            if (ModelState.IsValid)
            {
                outl.Insert(outlet);
                return View();
            }

            return View();
        }
        public ActionResult Update(Outlet outlet)
        {
            outl.Update(outlet);
            return View();
        }
        public ActionResult GetAll()
        {
            outl.GetAll();
            return View();
        }
        public ActionResult Delete(int ID)
        {
            outl.Delete(ID);
            return View();
        }
    }
}