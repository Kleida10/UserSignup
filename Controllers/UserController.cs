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
        Models.User user = new User();
        public IActionResult Index()
        {
            ViewBag.title = "Welcome ";
            ViewBag.user = user.Username;
            return View();
        }

        public IActionResult Add()
        {
            ViewBag.error = error;
            return View();
        }
        [HttpPost]
        public IActionResult Add(User user, string verify)
        {
            if (verify == null || user.Password == null)
            {
                error = "Password and Verify password can't be empty.";
                return View("Add");

            }
            else if (verify != user.Password)
            {
                error = "Password doesn't match";
                return View("Add");
            }
            else
            {
                return View("Index");
            }
        }

    }
}