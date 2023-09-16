using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyProjectITI
{
    public class Categary
    {
        [Key]
        public int cid { get; set; }

        public string cname { get; set; }
    }
}