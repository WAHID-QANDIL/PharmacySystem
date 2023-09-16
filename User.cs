using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyProjectITI
{
    public class User
    {
        [Key]
        public int id { get; set; }

        public string uName { get; set; }
        public string uEmail { get; set; }
        public string uPassword { get; set; }
    }
}