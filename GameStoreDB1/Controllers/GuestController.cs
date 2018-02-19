using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GameStoreDB1;

namespace GameStoreDB1.Controllers
{
    public class GuestController : Controller
    {
        private GameStoreLegacy_dbEntities db = new GameStoreLegacy_dbEntities();
        // GET: Guest
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Accessories()
        {
            return View();
        }
        public ActionResult Cart()
        {
            return View();
        }
        public ActionResult Consoles()
        {
            return View();
        }
        public ActionResult Games()
        {
            return View();
        }


    }
}