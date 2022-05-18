using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web_Entity.Model
{
   public class InventoryProducts
    {


        [Key]
        public int Id { get; set; }
        [Required]
        public int InventoryId { get; set; }
        [Required]
        public int ProductId { get; set; }
        [Required]
        public double Rate { get; set; }
        [Required]
        public double Qty { get; set; }
        [Required]
        public double Discount { get; set; }
    }
}
