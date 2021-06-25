using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MastersClass_MVC.Models;

namespace MastersClass_MVC.Controllers
{
    public class ItalianController : Controller
    {
        Context context = new Context();
        
        public IActionResult Index()
        {
            var result = context.courses.ToList();
            return View(result);
        }

        public IActionResult Level1()
        {
            var result = from a in context.courses
                             where a.level == 1
                             select a;
            return View(result.FirstOrDefault());
        }

        public IActionResult Level2()
        {
            var result = from a in context.courses
                         where a.level == 2
                         select a;
            return View(result.FirstOrDefault());
        }

        public IActionResult Level3()
        {
            var result = from a in context.courses
                         where a.level == 3
                         select a;
            return View(result.FirstOrDefault());
        }
    }
}
