using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using kendoui.Data;
using kendoui.Models;
namespace kendoui.Controllers
{
    public class HomeController : Controller
    {
        PizzashopsContext db = new PizzashopsContext();
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult Filter()
        {
            var pizzas = from m in db.Pizzas select m;
            return Json(pizzas, JsonRequestBehavior.AllowGet);
        }
    }
}