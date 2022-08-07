using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using log4net;
using MyIoc.Interfaces;
using MyIoc.Models;
using MyIoc.MyMvcFilters;

namespace MyIoc.Controllers
{
    public class HomeController : Controller
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(HomeController));

        private readonly IOwner _owner;
        public HomeController(IOwner iOwner)
        {
            this._owner = iOwner;
        }

        public ActionResult Index()
        {
            List<Owner> allOwners = _owner.getAllOwners();
            Owner owner = allOwners.FirstOrDefault<Owner>();

            Log.Info(owner.Id+"-"+owner.Name+"-"+owner.AddressId);

            //return Content(owner.Name);
            return View();
        }

        [MyIndexActionFilter]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            Log.Info("--About--");
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}