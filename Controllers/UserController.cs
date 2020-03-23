using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserSignup1.Models;
using UserSignup1.ViewModels;

namespace UserSignup1.Controllers
{
    public class UserController : Controller
    {
        public static List<AddUserViewModel> users = new List<AddUserViewModel>();
        public IActionResult Index()
        {
            ViewBag.title = "Welcome ";
            ViewBag.users = users;
            return View();
        }

        public IActionResult Add()
        {
            AddUserViewModel addUserViewModel = new AddUserViewModel(); 
            return View(addUserViewModel);
        }
        [HttpPost]
        public IActionResult Add(AddUserViewModel addUserViewModel)
        {
            if (ModelState.IsValid)
            {
                
                users.Add(addUserViewModel);
                return Redirect("/User");

            }

            return View(addUserViewModel);
            

        }

    }
}