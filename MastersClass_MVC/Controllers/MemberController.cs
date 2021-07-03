using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MastersClass_MVC.Models;
using Microsoft.AspNetCore.Http;

namespace MastersClass_MVC.Controllers
{
    public class MemberController : Controller
    {
        private readonly Context _context;

        public MemberController(Context context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login(string email, string password)
        {
            var user = _context.users.FirstOrDefault(w => w.email.Equals(email) && w.password.Equals(password));
            if(user != null)
            {
                HttpContext.Session.SetInt32("id", user.id);
                return Redirect("/Home/Index");
            }
            return Redirect("/Index");

        }

        public IActionResult Register()
        {
            return View();
        }

        public async Task<IActionResult> SignUp(User model)
        {
            await _context.AddAsync(model);
            await _context.SaveChangesAsync();

            return Redirect("/Home/Index");
        }

        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();
            return Redirect("/Home/Index");
        }
    }
}
