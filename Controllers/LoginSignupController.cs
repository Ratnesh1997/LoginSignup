using Login.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectLogin.Controllers
{
    public class LoginSignupController : Controller
    {
        DataContext db = new DataContext();
        public IActionResult Signup()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Signup(Register R)
        {
            if (ModelState.IsValid == true)
            {
                db.registers.Add(R);
                int a = db.SaveChanges();
                if (a > 0)
                {
                    ViewBag.InsertMessage="<script>alert('Registerd Successfully ______!!') </script>";
                }
                else
                {
                    ViewBag.InsertMessage = "Registration Failed Try Again";
                }
            }
            return View();
        }
    }
}
