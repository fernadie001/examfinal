using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using examfinal.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace examfinal.Controllers
{
    public class HomeController : Controller
    {
        private Mycontext _context;

        public HomeController(Mycontext context)
        {
            _context = context;
        }
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("Register")]
        public IActionResult Register(User newUser)
        {
            if(ModelState.IsValid)
            {
                if(_context.Users.Any(e => e.Email == newUser.Email))
                {
                    ModelState.AddModelError("Email", "Email is already in use!");
                    return View("Index");
                } else {
                    PasswordHasher<User> Hasher = new PasswordHasher<User>();
                    newUser.Password = Hasher.HashPassword(newUser, newUser.Password);
                    _context.Add(newUser);
                    _context.SaveChanges();
                    HttpContext.Session.SetInt32("logged_in", newUser.UserId);
                    return RedirectToAction("Dashboard");
                }
            } else {
                return View("Index");
            }
        }


        [HttpPost("Login")]
        public IActionResult Login(LUser login)
        {
            if(ModelState.IsValid)
            {
                User userInDb = _context.Users.FirstOrDefault(u => u.Email == login.LEmail);
                if(userInDb == null)
                {
                    ModelState.AddModelError("LEmail", "Invalid login attempt");
                    return View("Index");
                } else {
                    var hasher = new PasswordHasher<LUser>();
                    var result = hasher.VerifyHashedPassword(login, userInDb.Password, login.LPassword);
                    if(result == 0)
                    {
                        ModelState.AddModelError("LEmail", "Invalid login attempt");
                        return View("Index");
                    }
                    HttpContext.Session.SetInt32("logged_in", userInDb.UserId);
                    return RedirectToAction("Dashboard");
                }
            } else {
                return View("Index");
            }
        }

        [HttpGet("Dashboard")]
        public IActionResult Dashboard()
        {
            Console.WriteLine("entering dashboard");
            int? loggedin = HttpContext.Session.GetInt32("logged_in");
            Console.WriteLine(loggedin);
            if(loggedin == null)
            {
                return RedirectToAction("Index");
            } else {
                // User thisUser = _context.Users.Include(s => s.Commissions).FirstOrDefault(u => u.UserId == (int)loggedin);
                // ViewBag.LoggedIn = thisUser;
                // Console.WriteLine(thisUser.Commissions.Count);
                //ViewBag.LoggedIn = _context.Users.Include(s => s.Commissions).FirstOrDefault(u => u.UserId == (int)loggedin);
                // ViewBag.Orders = _context.Orders.Include(d => d.Activity).Where(a => a.UserId == (int)loggedin);
                // ViewBag.Commissions = _context.Orders.Include(f => f.Activity).Where(h => h.Activity.UserId == (int)loggedin);
                ViewBag.AllHobbies=_context.Activity.Include(a=>a.Seller).ToList();
                return View();
            }
        }

        [HttpGet("HobbiesDetail/{Id}")]
        public IActionResult HobbiesDetail(int Id)
        {
            int? loggedin = HttpContext.Session.GetInt32("logged_in");
            if(loggedin == null)
            {
                return RedirectToAction("Index");
            }
            ViewBag.activityDetail= _context.Activity.FirstOrDefault(x=>x.ActivityId==Id);
            ViewBag.User= loggedin;
            return View();
        }

        [HttpPost("AddEnthusiast")]
        public IActionResult AddEnthusiast(ActivityHistory NewEnthusiast)
        {
            _context.Add(NewEnthusiast);
            _context.SaveChanges();
            return RedirectToAction("Dashboard");
        }

        [HttpGet("AddActivity")]
        public IActionResult AddActivity()
        {
            int? loggedin = HttpContext.Session.GetInt32("logged_in");
            if(loggedin == null)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpPost("CreateActivity")]

        public IActionResult CreateActivity(Actividad newActivity)
        {
            if (ModelState.IsValid)
            { 
                int? loggedin = HttpContext.Session.GetInt32("logged_in");
                newActivity.UserId = (int)loggedin;
                _context.Add(newActivity);
                _context.SaveChanges();
                return RedirectToAction("Dashboard");
            }   else {
                    return View("AddActivity");
            }
        }

        [HttpGet("AllGigs")]

        public IActionResult AllActividades()
        {
            ViewBag.AllActivity =_context.Activity.ToList();
            return View();
        }
    }
}
