using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Healthy_Food.Models;
using System.Security.Cryptography;
using System.Text;
using System.Web.Security;

namespace Healthy_Food.Controllers
{
    public class UsersController : Controller
    {
        private DataContext db = new DataContext();
        // GET: Users
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(Models.Users users)
        {
            if (ModelState.IsValid)
            {
                var check = db.User.FirstOrDefault(s => s.Email.Equals(users.Email));
                if (check == null)
                {
                    // convert pass thanh md5
                    users.Password = GetMD5(users.Password);
                    db.User.Add(users);
                    db.SaveChanges();
                    FormsAuthentication.SetAuthCookie(users.Email, true);// xac nhận đã đăng nhập
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewBag.Error = "Email đã tồn tại!";
                }
            }
            return View();
        }

        private string GetMD5(string str)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] frData = Encoding.UTF8.GetBytes(str);
            byte[] toData = md5.ComputeHash(frData);
            string hashString = "";
            foreach (var i in toData)
            {
                hashString += i.ToString("x2");
            }
            return hashString;
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Models.Users users)
        {
            if (ModelState.IsValid)
            {
                users.Password = GetMD5(users.Password);
                var data = db.User.Where(s => s.Email.Equals(users.Email) && s.Password.Equals(users.Password)).FirstOrDefault();
                if (data != null)
                {
                    FormsAuthentication.SetAuthCookie(data.Email, true);// xac nhận đã đăng nhập
                    return RedirectToAction("Index", "Home");
                }
            }
            return View();
        }
    }
}