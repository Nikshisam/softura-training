using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Product_Table_Task.Models
{
    public class Product
    {
        [Key]
        [Required]
        public String ProductName { get; set; }
        public int ProductID { get; set; }
        
    }
}
