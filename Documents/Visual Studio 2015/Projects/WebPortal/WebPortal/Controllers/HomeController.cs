using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebPortal.Models;

namespace WebPortal.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult SignUp()
        {
           
            return View("SignUp");
        }

        public ActionResult LogIn()
        {

            return View();
        }

        #region Login Page Submit
        public ActionResult Submit()
        {

            return View("LogIn");
        }


        #endregion




    }
}