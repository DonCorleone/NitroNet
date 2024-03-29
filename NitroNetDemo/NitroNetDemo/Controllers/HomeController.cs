﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NitroNetDemo.Controllers
{
    public class HomeController : Controller
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

        public ActionResult About()
        {
            var header = GetHeaderModel("About");
            var footer = GetFooterModel();

            // var model = new
            // {
            //     Items = new [] { "Cat", "Dog" },
            //     Users = new [] {
            //         new User{ Name = "Jim" },
            //         new User{ Name = "Bob" }
            //     },
            //     Header = header,
            //     Footer = footer
            // };

            var model = new {
                Name = "Bob",
                Department = new {
                    Name = "Sector 7G"
                },
	            IsAdmin = false,
                Header = header,
                Footer = footer
            };


            return View("frontend/patterns/molecules/about/about", model);
        }

        public ActionResult Contact()
        {
            //ViewBag.Message = "Your contact page.";
            var header = GetHeaderModel("Contact");
            var footer = GetFooterModel();
            var mails = GetMails();
            var address = GetAddress();
            

            var model = new
            {
                Message = "Your contact page.",
                Header = header,
                Footer = footer,
                Mails = mails,
                Address = address
            };

            return View("frontend/patterns/molecules/contact/contact", model);
            //return View();
        }

        private object GetAddress()
        {
            return new
            {
                Street = "Strada bella",
                City = "Milano",
                PhoneNr = "111.222.3333 "
            };
        }

        private object GetMails()
        {
            var mail1 = new
            {
                Name = "Support",
                MailAddress = "support@example.com"
            };
            var mail2 = new
            {
                Name = "Marketing",
                MailAddress = "marketing@example.com"
            };
            return new Collection<Object> {mail1, mail2};
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

    internal class User
    {
        public string Name { get; set; }
    }
}