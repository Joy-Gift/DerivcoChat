using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ChatAppWinterSchool.Models;
using LiteDB;
using ChatAppWinterSchool.DataAccess;

namespace ChatAppWinterSchool.Controllers
{
    public class HomeController : Controller
    {
        private IChatSystemStore _store;

        public HomeController(IChatSystemStore store)
        {
            _store = store; 
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginCredentials lc)
        {
           // using (var db = new LiteDatabase(@"Chat.db"))
           // {
            //    var hist = db.GetCollection<User>("users");
                
                
           // }
           if (lc.NickName.Equals("Shailen") && lc.Password.Equals("1234"))
            {
                return RedirectToAction("Index", "Chat");
            }
           else
           {
               return View();
           }

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
