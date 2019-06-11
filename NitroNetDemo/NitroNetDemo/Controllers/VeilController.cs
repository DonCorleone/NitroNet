using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NitroNetDemo.Controllers
{
    public class VeilController : Controller
    {
        public ActionResult Index()
        {
            var header = GetHeaderModel("Home");
            var footer = GetFooterModel();

            var model = new
            {
                GettingStarted =
                "ASP.NET MVC gives you a powerful, patterns-based way to build dynamic websites that enables a clean separation of concerns and gives you full control over markup for enjoyable, agile development.",
                Header = header,
                Footer = footer
            };
            return View("frontend/patterns/molecules/index/index", model);
            //return View();
        }
                private object GetHeaderModel(string title)
        {
            return new
            {
                Title = title,
                CssPath = "/Content/css",
                ModernizrBundle = "/bundles/modernizr"
            };
        }

        private object GetFooterModel()
        {
            return new
            {
                DateTime = DateTime.Now.Year,
                JqueryBundle = "/bundles/jquery",
                BootstrapBundle = "/bundles/bootstrap",
                ScriptBundle = "/Scripts/respond.js"
            };
        }
    }
}