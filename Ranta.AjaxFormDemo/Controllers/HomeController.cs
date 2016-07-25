using Ranta.AjaxFormDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ranta.AjaxFormDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult New()
        {
            return View();
        }

        [HttpPost]
        public JsonResult New(NewModel model)
        {
            if (ModelState.IsValid)
            {
                ModelState.AddModelError("ok", "OK");
            }

            return Json(2);
        }
    }
}