using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MastersClass_MVC.Models
{
    public class Courses
    {
        [Key]
        public int id { get; set; }
        public String name { get; set; }
        public String time { get; set; }

        public string description { get; set; }

        public int level { get; set; }
        public String videolink { get; set; }

        public String imageslink { get; set; }
        
        public String category { get; set; }
    }

}
