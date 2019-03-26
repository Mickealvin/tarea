using formularioHELPRS1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace formularioHELPRS1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Resultado(persona obj, FormCollection collection)
        {
            string hobbys = collection["Hobbys"];

            obj.Hobbys = hobbys;
            return View(obj);
        }

        public ActionResult persona()
        {
            List<string> pasatiempos = new List<string>();


            pasatiempos.Add("Programar");
            pasatiempos.Add("Estudiar");
            pasatiempos.Add("Escuchar Musica");
            pasatiempos.Add("Comer");

            ViewBag.pasatiempo = pasatiempos;
            return View();
        }
    }
}