using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using POSEntity.Model.SetupFile;
using POSService;

namespace PointOfSaleManagementSystem.Controllers
{
    public class PartyController : Controller
    {
        // GET: Party
        PartyService type = new PartyService();
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Party party)
        {
            if (ModelState.IsValid)
            {
                type.Insert(party);
            }
            return View();
        }
        public ActionResult Update(Party party)
        {
            type.Update(party);
            return View();
        }
        public ActionResult GetAll()
        {
            type.GetAll();
            return View();
        }
        public ActionResult Delete(int ID)
        {
            type.Delete(ID);
            return View();
        }
    }
}