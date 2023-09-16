using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyProjectITI
{
    public class Medicien
    {
        [Key]
        public int mid_id { get; set; }
        public string mid_name { get; set; }
        public float mid_price { get; set; }
        public DateTime productionDate { get; set; }
        public DateTime expireDate { get; set; }
        public int quantity { get; set; }
        public int cid { get; set; }
        [ForeignKey ("cid")]
        public virtual Categary Categary { get; set; }



    }
}
