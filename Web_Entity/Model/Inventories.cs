using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web_Entity.Model
{
   public class Inventories
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public int BillNo { get; set; }
        [Required]
        public int CustomerId { get; set; }
        [Required]
        public double TotalDiscount { get; set; }
        [Required]
        public double TotalBillAmount { get; set; }
        [Required]
        public double DueAmount { get; set; }
        [Required]
        public double PaidAmount { get; set; }

    }
}
