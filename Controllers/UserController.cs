using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserSignup1.Models;

namespace UserSignup1.Controllers
{
    public class UserController : Controller
    {
        public string error = null;
        public static List<User> users = new List<User>();
        public IActionResult Index()
        {
            ViewBag.title = "Welcome ";
            ViewBag.users = users;
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(User user, string verify)
        {
            if (verify == null || user.Password == null)
            {
                ViewBag.error = "Password and Verify password can't be empty.";
                return View("Add");

            }
            else if (verify != user.Password)
            {
                ViewBag.error = "Password doesn't match";
                return View("Add");
            }
            else
            {
                users.Add(user);
                return Redirect("/User");
            }
        }

    }
}