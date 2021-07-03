using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MastersClass_MVC.Models
{
    public class User
    {
        [Key]
        public int id { get; set; }

        public string email { get; set; }

        public string password { get; set; }

        public int italianlevel1 { get; set; }
        public int italianlevel2 { get; set; }
        public int italianlevel3 { get; set; }
        public int turkishlevel1 { get; set; }
        public int turkishlevel2 { get; set; }
        public int turkishlevel3 { get; set; }

        public int fareastlevel1 { get; set; }

        public int fareastlevel2 { get; set; }

        public int fareastlevel3 { get; set; }


    }
}
