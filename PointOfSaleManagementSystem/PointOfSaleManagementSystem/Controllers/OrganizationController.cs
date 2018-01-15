using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using POSEntity.Model.SetupFile;
using POSService;

namespace PointOfSaleManagementSystem.Controllers
{
    public class OrganizationController : Controller
    {
        // GET: Organization
        OrganizationService orgs = new OrganizationService();
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Organization org)
        {
            if (ModelState.IsValid)
            {
                orgs.Insert(org);
                return RedirectToAction("GetAll");
            }

            return View();
        }

        [HttpGet]
        public ActionResult Update(int Id)
        {
            var org = orgs.Get(Id);
            return View(org);
        }
        [HttpPost]
        public ActionResult Update(Organization org)
        {
            orgs.Update(org);
            return RedirectToAction("GetAll");
        }
        public ActionResult GetAll()
        {
            var org = orgs.GetAll();
            return View(org);
        }
        public ActionResult Delete(int ID)
        {
             orgs.Delete(ID);
            return RedirectToAction("GetAll");
        }
        public ActionResult Details(int ID)
        {
            Organization org = orgs.Get(ID);
            return View(org);
        }
    }
}