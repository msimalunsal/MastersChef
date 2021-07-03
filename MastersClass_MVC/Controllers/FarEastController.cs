using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MastersClass_MVC.Models;
using Microsoft.AspNetCore.Http;
using MastersClass_MVC.Filter;
using Microsoft.Data.SqlClient;

namespace MastersClass_MVC.Controllers
{
    [UserFilter]
    public class FarEastController : Controller
    {
        Context context = new Context();

        public IActionResult Index()
        {
            var result = from b in context.courses
                         where b.category == "fareast"
                         select b;
            return View(result.ToList());
        }

        public IActionResult Level1()
        {
            if (!HttpContext.Session.GetInt32("id").HasValue)
            {
                return Redirect("/Member/Index");
            }
            var result = from a in context.courses
                         where a.level == 1
                         select a;
            return View(result.FirstOrDefault());
        }

        public IActionResult Level2()
        {
            var iduser = HttpContext.Session.GetInt32("id");
            var watchcount = from a in context.users
                             where a.id == iduser
                             select a;
            if (watchcount.FirstOrDefault().fareastlevel1.Equals(1))
            {
                var result = from a in context.courses
                             where a.level == 2
                             select a;
                return View(result.FirstOrDefault());
            }
            return Redirect("/FarEast/Index");

        }

        public IActionResult Level3()
        {
            var iduser = HttpContext.Session.GetInt32("id");
            var watchcount = from a in context.users
                             where a.id == iduser
                             select a;
            if (watchcount.FirstOrDefault().fareastlevel2.Equals(2))
            {
                var result = from a in context.courses
                             where a.level == 3
                             select a;
                return View(result.FirstOrDefault());
            }
            return Redirect("/FarEast/Index");

        }

        public IActionResult UpWatchFarEast(int levelno)
        {
            var iduser = HttpContext.Session.GetInt32("id");
            var watchcount = from a in context.users
                             where a.id == iduser
                             select a;
            if (levelno.Equals(1) && watchcount.FirstOrDefault().fareastlevel1.Equals(0))
            {
                watchcount.FirstOrDefault().fareastlevel1++;
            }
            else if (levelno.Equals(2) && watchcount.FirstOrDefault().fareastlevel2.Equals(0))
            {
                watchcount.FirstOrDefault().fareastlevel2++;
            }
            if (levelno.Equals(3) && watchcount.FirstOrDefault().fareastlevel3.Equals(0))
            {
                watchcount.FirstOrDefault().fareastlevel3++;
            }
            context.SaveChanges();
            return Redirect("/FarEast/Index");
        }
    }
}
