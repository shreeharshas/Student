using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DashBoardMVC.Models;

namespace DashBoardMVC.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            ViewBag.UsageSample =
            @"Please Use the Url 'Demo/Test' or 'Demo/Test/1' to see the Book Details";

            return View();
        }

        public ActionResult Test()
        {
            Book book = new Book()
            {
                ID = 1,
                BookName = "Data Mining",
                AuthorName = "Tom Mitchell",
                ISBN = "NA"
            };

            return View(book);

        }
    }
}