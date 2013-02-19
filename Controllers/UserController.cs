using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using trackerInversion.Models;

namespace trackerInversion.Controllers
{
    public class UserController : Controller
    {
        //
        // GET: /User/

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Models.User user)
        {
            if (ModelState.IsValid)
            {
                if (user.IsValid(user.Usuario, user.Password))
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                     ModelState.AddModelError("","Acceso Denegado");
                }            
            }

            return View(user);
        }

    }
}
