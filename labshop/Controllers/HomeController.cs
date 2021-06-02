using labshop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Hosting;
using System.IO;


namespace labshop.Controllers
{
    public class HomeController : Controller
    {
        public int In_User = 0;
        public string In_User_Name;
        private readonly IWebHostEnvironment _appEnvironment;
        [TempData]
        public static string In_User_Mail { get; set; }
        ShopContext db;
        public HomeController(ShopContext context, IWebHostEnvironment appEnvironment)
        {
            db = context;
            _appEnvironment = appEnvironment;
        }
        ////////////////////////////////////////////////////////////////////////
        //ПОЧАТКОВІ СТОРІНКИ
        public ActionResult Index()
        {
            
            IEnumerable<Tovar> tovars = db.tovars;
            ViewBag.Tovary = tovars;
            return View();
        }
        [HttpGet]
        public ActionResult Index2()
        {
            IEnumerable<Tovar> tovars = db.tovars;
            ViewBag.Tovary = tovars;
            return View();
        }
        ///////////////////////////////////////////////////////////////
        //РЕЄСТРАЦІЯ
        [HttpGet]
        public ActionResult registerpage()
        {
            return View();
        }
        [HttpPost]
        public IActionResult registerpage(User user, string UserMail, string UserName, string UserPassword)
        {
            string cond = @"(\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*)";
            
            IEnumerable<User> users = db.users;
            ViewBag.users = users;
            int check = 0;
            foreach (var us in ViewBag.users)
            {
                if (us.UserMail == UserMail || us.UserName == UserName || UserName == null || UserPassword == null)
                {
                    check = 1;
                }
                
            }
            if (Regex.IsMatch(UserMail, cond) && check == 0)
            {
                db.users.Add(user);
                db.SaveChanges();
                Index2();
                In_User_Mail = UserMail;
                return View("Index2");
            }
            else
            {
                if(check == 1)
                {
                    ViewBag.Mеssage = "Даний користувач вже зареєстрований, або не всі поля заповнені";
                }
                
                else
                {
                    ViewBag.Mеssage = "Не правильно введена пошта.";
                }
                return View("registerpage");
            }
            
            
        }
        ////////////////////////////////////////////////////////////////////////
        //ВХІД
        [HttpGet]
        public ActionResult loginpage()
        {
            return View();
        }
        [HttpPost]
        public IActionResult loginpage(User user, string UserMail, string UserPassword)
        {
            foreach (var pipl in db.users)
            {
                if (UserMail == pipl.UserMail && UserPassword == pipl.UserPassword)
                {
                    In_User = 1;
                    Index2();
                    In_User_Mail = UserMail;
                    return View("Index2");
                }
                if(UserMail == "admin" && UserPassword == "1234")
                {
                    adminpanel();
                    return View("adminpanel");
                }
            }
            return View("loginpage");
        }

        //////////////////////////////////////////////////////////////////
        //АДМІН ПАНЕЛЬ
        [HttpGet]
        public IActionResult adding()
        {
            return View();
        }
        [HttpPost]
        public IActionResult adding(Tovar tovar, Download download, string TovarName)
        {
            int check = 0;
            foreach (var tov in db.tovars)
            {
                if (TovarName == tov.TovarName)
                {
                    check = 1;
                }
            }
            if (check == 0)
            {
                db.tovars.Add(tovar);
                db.downloads.Add(download);
                db.SaveChanges();
            }

            adminpanel();
            return View("adminpanel");
        }
        [HttpGet]
        public IActionResult adminpanel()
        {
            IEnumerable<Tovar> tovars = db.tovars;
            ViewBag.Tovars = tovars;
            IEnumerable<BuyTovar> buyTovars = db.buyTovars;
            ViewBag.buytov = buyTovars;
            IEnumerable<User> users = db.users;
            ViewBag.users = users;
            return View();
        }
        [HttpGet]
        public IActionResult editing(int? id)
        {
            IEnumerable<Tovar> tovars = db.tovars;
            ViewBag.tovars = tovars;
            IEnumerable<Download> dloads = db.downloads;
            ViewBag.dwn = dloads;
            ViewBag.uid = id;
            return View();
        }
        [HttpPost]
        public IActionResult editing(Tovar tovar, Download download, string TovarName, string TovarPrice, string Link, string DemoLink)
        {

            int check = 0;
            foreach(var tov in db.tovars)
            {
                if(TovarName == tov.TovarName)
                {
                    check = 1;
                }
            }
            if (check == 0)
            {
                db.tovars.Update(tovar);
                db.downloads.Update(download);
                db.SaveChanges();
            }
            
            adminpanel();
            return View("adminpanel");
        }
        [HttpGet]
        public IActionResult deleting(int? id)            
        {
            IEnumerable<Tovar> tovars = db.tovars;
            ViewBag.tovars = tovars;
            IEnumerable<Download> dloads = db.downloads;
            ViewBag.dwn = dloads;
            ViewBag.uid = id;
            return View();
        }
        [HttpPost]
        public IActionResult deleting(Tovar tovar, Download download)
        {
            db.tovars.Remove(tovar);
            db.downloads.Remove(download);
            db.SaveChanges();
            adminpanel();
            return View("adminpanel");
        }
        [HttpGet]
        public IActionResult deleteuser(int? id)
        {
            IEnumerable<User> users = db.users;
            ViewBag.users = users;
            ViewBag.uid = id;
            return View();
        }
        [HttpPost]
        public IActionResult deleteuser(User user)
        {
            db.users.Remove(user);
            db.SaveChanges();
            adminpanel();
            return View("adminpanel");
        }
        [HttpGet]
        public IActionResult deleteorder(int? id)
        {
            IEnumerable<BuyTovar> buyTovars = db.buyTovars;
            ViewBag.btov = buyTovars;
            ViewBag.uid = id;
            return View();
        }
        [HttpPost]
        public IActionResult deleteorder(BuyTovar bt)
        {
            db.buyTovars.Remove(bt);
            db.SaveChanges();
            adminpanel();
            return View("adminpanel");
        }
        //////////////////////////////////////////////////////////////////
        //ПОКУПКА ТОВАРУ
        [HttpGet]
        public IActionResult Buy(int? id)
        {
            IEnumerable<BuyTovar> bt = db.buyTovars;
            ViewBag.Pokupky = bt;
            IEnumerable<Tovar> tovars = db.tovars;
            ViewBag.Tovary = tovars;
            IEnumerable<Download> downs = db.downloads;
            ViewBag.linky = downs;
            if (id == null) return RedirectToAction("Index2");
            ViewBag.Id = id;
            ViewBag.usermail = In_User_Mail;
            return View();
        }
        [HttpPost]
        public ActionResult Buy(Tovar tovar,BuyTovar bt,string action, int TovarId, string TovarName)
        {
            if (action == "buy")
            {
                if (TovarId == tovar.TovarId)
                {
                    tovar.NumberOfPur = tovar.NumberOfPur + 1;
                    db.tovars.Update(tovar);
                    bt.DateTime =  DateTime.Now;
                    db.buyTovars.Add(bt);
                    db.SaveChanges();
                    return View("redirect");
                }
            }
            if(action == "downloadfull")
            {
                
            }
            Index2();
            return View("Index2");
        }
       
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
