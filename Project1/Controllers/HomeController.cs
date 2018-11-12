using Project1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult Mission()
        {
            return View();
        }

        public ActionResult Submit(string value)
        {
            Mission mission = new Mission();
            if (value == "Shanghai")
            {
                mission.MissionName = "China Shanghai Mission";
                mission.PresidentName = "Xi Jin Ping";
                mission.Address = "1912 Democracy St, Shanghai";
                mission.Language = "Mandarin Chinese";
                mission.Climate = "Not too hot, mildly humid";
                mission.Religion = "Materialism";
            }
            else if (value == "Pyongyang")
            {
                mission.MissionName = "North Korea Pyongyang Mission";
                mission.PresidentName = "Kim Jong Eun";
                mission.Address = "1776 America Blvd, Pyongyang";
                mission.Language = "Korean";
                mission.Climate = "Politically sensitive";
                mission.Religion = "Kim Ancestral Worship";
            }
            else
            {
                mission.MissionName = "Spirit Prison Mission";
                mission.PresidentName = "Jesus";
                mission.Address = "Paradise Temple Work Mission Department Room AD-33";
                mission.Language = "Multilingual";
                mission.Climate = "Not applicable";
                mission.Religion = "Awaiting Conversion-ism";
            }
            ViewBag.Output += "<div class=\"mission-textbox\">";
            ViewBag.Output += "<h4>Mission Name: " + mission.MissionName + "</h4>";
            ViewBag.Output += "<h4>President's Name: " + mission.PresidentName + "</h4>";
            ViewBag.Output += "<h4>Mission Address: " + mission.Address + "</h4>";
            ViewBag.Output += "<h4>Language Spoken: " + mission.Language + "</h4>";
            ViewBag.Output += "<h4>Area Climate: " + mission.Climate + "</h4>";
            ViewBag.Output += "<h4>Local Religion: " + mission.Religion + "</h4>";
            ViewBag.Output += "</div>";
            return View("MissionInformation");
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
    }
}