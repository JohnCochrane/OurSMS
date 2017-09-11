using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OurSMS.Models;

namespace OurSMS.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            var entities = new OurSMSEntitiesNew2();
        
            return View(entities.Users.ToList());
        }
    }
}