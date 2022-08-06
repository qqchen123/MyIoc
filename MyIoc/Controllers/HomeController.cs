using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyIoc.Interfaces;
using MyIoc.Models;

namespace MyIoc.Controllers
{
    public class HomeController : Controller
    {
        private IOwner _owner;
        public HomeController(IOwner iOwner)
        {
            this._owner = iOwner;
        }

        public ActionResult Index()
        {
            List<Owner> allOwners = _owner.getAllOwners();
            Owner owner = allOwners.FirstOrDefault<Owner>();
            return Content(owner.Name);
            //return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}