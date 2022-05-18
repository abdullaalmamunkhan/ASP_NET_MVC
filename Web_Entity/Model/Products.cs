﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web_Entity.Model
{
    public class Products
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public String Code { get; set; }
        [Required]
        public String Name { get; set; }
        [Required]
        public String Rate { get; set; }

    }
}
