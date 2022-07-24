using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Models;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;

namespace BookStore.Controllers
{
    public class LoginController : Controller
    {
        
        [HttpPost]
        public IActionResult Login(IFormCollection form)
        {
            using (var context = new Book_SellingContext( ))
            {
                User user = context.Users.FirstOrDefault(x => x.Email.Equals(form["email"]));
                if (user.Password.Equals(form["password"])) 
                {
                    var session = HttpContext.Session;
                    string jsonuser = JsonConvert.SerializeObject(user);
                    session.SetString("User", jsonuser);
                    return RedirectToAction("Index");
                }

            }
            return View("Login");
        }
        [Route("/signup")]
        public IActionResult SignUp()
        {
            return View("SignUp");
        }


    }
}
