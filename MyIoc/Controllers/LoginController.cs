using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyIoc.Models;
using MyIoc.MyMvcFilters;

namespace MyIoc.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [MyAllowAnonynous]
        public ActionResult Index()
        {
            return View();
        }

     

        // POST: Login/Create
        [HttpPost]
        [MyAllowAnonynous]
        public ActionResult Index(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                string username = collection["UserName"];  //collection.GetValue("UserName").ToString();
                string password = collection["Password"];  //collection.GetValue("Password").ToString();
                if (username=="test" && password == "123123")
                {
                    var currentUser = new CurrentUser()
                    {
                        Id = 1,
                        UserName = username,
                        Password = password
                    };
                    HttpContext.Session["CurrentUser"] =  currentUser;
                    return Redirect("/Home/Index");
                }
                else
                {
                    return View("Index");
                }
            }
            catch
            {
                return View("Index");
            }
        }

        public ActionResult LogOut()
        {
            HttpContext.Session["CurrentUser"] = null;
            return RedirectToAction("Index");
        }

        // POST: Login/Edit/5
        //[HttpPost]
        //public ActionResult Edit(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: Login/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        // POST: Login/Delete/5
        //[HttpPost]
        //public ActionResult Delete(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
