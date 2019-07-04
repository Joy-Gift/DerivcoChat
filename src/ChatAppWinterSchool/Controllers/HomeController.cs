using ChatAppWinterSchool.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;

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

            if (_store.ValidateUser(lc))
            {
                // then move activate lobby 
                //Console.WriteLine("");
                return RedirectToAction("Index", "Chat");
            }
            else
            {
                // give message on login page to retry
                Console.WriteLine("Invalid password ");
            }


            return Ok();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
