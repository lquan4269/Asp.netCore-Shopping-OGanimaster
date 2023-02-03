using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shopping.Models;
using Shopping.Repository;

namespace Shopping.Controllers
{
    public class UserController : Controller
    {
        ShoponlContext db = new ShoponlContext();



        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginModel L) 
        {
            if (ModelState.IsValid) {
                UserRepository UR = new UserRepository();
                //User usr = db.Users.FirstOrDefault(x => x.Email.Equals(L.Email) && x.Password.Equals(Encrypt.MD5Hash(L.Password)));
                if (UR.CheckLogin(L.Email, L.Password))
                {
                    HttpContext.Session.SetString("Email", L.Email);//session
                    HttpContext.Session.SetString("Password",L.Password);
                    return RedirectToAction("Index", "Home");
                }
                else 
                {
                    ViewBag.Error = "Please enter your UserName and Password";
                }
            }
            return View(L);
        }


        public IActionResult Register()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Register(RegisterModel R)
        {
            UserRepository UR = new UserRepository();
            if (ModelState.IsValid) {



                if (UR.CheckUserName(R.Name) && UR.CheckEmail(R.Email))
                {
                    User u = new User();
                    u.UserName = R.Name;
                    u.Password = Encrypt.MD5Hash(R.Password);
                    u.Email = R.Email;
                    u.Adress = R.Adress;
                    u.PhoneNum = R.Phone;
                    db.Users.Add(u);
                    db.SaveChanges();
                    return RedirectToAction("Login", "User");
                }
                else {
                    ModelState.AddModelError("Register", "Error");
                }
            }
            return View();
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }

        //lich su don hang da dat
    }
}
