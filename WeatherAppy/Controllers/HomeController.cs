using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WeatherAppy.Models;

namespace WeatherAppy.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // GET: WeatherJS
        public ActionResult WeatherJS()
        {
            return View();
        }

        //GET:  WeatherOrNot
        public ActionResult WeatherOrNot()
        {
            return View();
        }

        //GET:  GetWeather
        public JsonResult GetWeather()
        {
            WeatherClass weath = new WeatherClass();
            return Json(weath.getWeatherForecast(), JsonRequestBehavior.AllowGet);
        }
    }
}