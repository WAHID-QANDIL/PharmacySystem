using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyProjectITI
{
    public class User_mediciens
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("User")]
        public int UserID { get; set; }

        public string Name { get; set; }

        [ForeignKey("Medicien")]
        public int mid_id { get; set; }

        public string mid_name { get; set; }
        public int quantity { get; set; }

        public virtual User User { get; set; }
        public virtual Medicien Medicien { get; set; }
    }
}