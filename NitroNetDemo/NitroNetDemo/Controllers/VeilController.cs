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
        public ActionResult Movies()
        {
            var header = GetHeaderModel("Movies");
            var footer = GetFooterModel();

            var model = new
            {
                AlbumName = "F♯ A♯ ∞",
                Artist = new
                {
                    ArtistName = "Godspeed You! Black Emperor"
                },
                Tracks = new[] {
                    new {
                        TrackName = "The Dead Flag Blues",
                        Length = "00:16:27"
                    },
                    new {
                        TrackName = "East Hastings",
                        Length = "00:17:58"
                    },
                    new {
                        TrackName = "Providence",
                        Length = "00:29:02"
                    }}
                ,
                IsAvailableOnVinyl = true,
                WasUSNumberOne = false,
                Reviews = new[] { "" },
                Header = header,
                Footer = footer
            };
            return View("frontend/patterns/molecules/movies/movies", model);
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