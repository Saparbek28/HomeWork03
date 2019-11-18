using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Download(int music)
        {
            switch (music)
            {
                case 1: return File("/music-file/HU.mp3", "audio", "HU.mp3");
                case 2: return File("~/music-file/PR.mp3", "audio", "PR.mp3");
                case 3: return File("~/music-file/TDG.mp3", "audio", "TDG.mp3");

                default: return HttpNotFound();
            }

        }
    }
}