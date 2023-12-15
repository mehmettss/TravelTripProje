using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        Contex c =new Contex();
        public ActionResult Index()
        {
            
            var degerler = c.Blogs.Take(4).ToList();
            return View(degerler);
        }
        public ActionResult About()
        {
            return View();
        }
        public PartialViewResult Partial1()
        {
            var deger = c.Blogs.Take(10).ToList();
            return PartialView(deger);
        }
        public PartialViewResult Partial2()
        {
            var deger =c.Blogs.Take(3).ToList();
            return PartialView(deger);
        }
        public PartialViewResult Partial3()
        {
            var deger = c.Blogs.Take(3).OrderByDescending(x=>x.ID).ToList();
            return PartialView(deger);
        }
    }
}