using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace MvcLab1.Controllers
{
    public class FilesController : Controller
    {
        // GET: Files
        public ActionResult Index()
        {
            string[] files = Directory.GetFiles(Server.MapPath("~/TextFiles"));
            return View(files);
        }


        public ActionResult SelectedTextDetail(string id)
        {
            string path = "~/TextFiles/" + id +".txt";
            string text = System.IO.File.ReadAllText(Server.MapPath(path));
            ViewBag.cot = text;
            return View();
        }
    }
}