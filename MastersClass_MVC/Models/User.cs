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
    }
}
