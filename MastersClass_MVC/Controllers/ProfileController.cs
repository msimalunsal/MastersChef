using MastersClass_MVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MastersClass_MVC.Controllers
{
    public class ProfileController : Controller
    {
        Context context = new Context();

        public IActionResult Index()
        {
            var iduser = HttpContext.Session.GetInt32("id");
            var result = from a in context.users
                         where a.id == iduser
                         select a;
            var sum = result.FirstOrDefault().italianlevel1 + result.FirstOrDefault().italianlevel2 + result.FirstOrDefault().italianlevel3;
            var sum2 = result.FirstOrDefault().turkishlevel1 + result.FirstOrDefault().turkishlevel2 + result.FirstOrDefault().turkishlevel3;
            var sum3 = result.FirstOrDefault().fareastlevel1 + result.FirstOrDefault().fareastlevel2 + result.FirstOrDefault().fareastlevel3;

            ViewBag.sum = sum * 34;
            ViewBag.sum2 = sum2 * 34;
            ViewBag.sum3 = sum3 * 34;

            return View();
        }
    }
}
