using AdminUserApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminUserApp.Controllers
{
    public class DashboardController : Controller
    {
        User user;
        public ActionResult AdminDashboard()
        {
            user = (User)Session["User"];
            if (Session["User"] == null || user.rol.RoleId != 1)
            {
                return RedirectToAction("Login", "Account");
            }
            return View();
        }

        public ActionResult UserDashboard()
        {
            user = (User)Session["User"];
            if (Session["User"] == null || user.rol.RoleId != 2)
            {
                return RedirectToAction("Login", "Account");
            }
            return View();
        }
    }
}