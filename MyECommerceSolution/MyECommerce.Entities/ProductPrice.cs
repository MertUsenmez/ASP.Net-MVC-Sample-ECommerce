using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyECommerce.Entities
{
    [Table("ProductPrice")]
    public class ProductPrice : NeededUsername
    {
        [Required]
        public double PurcasePrice { get; set; }

        [Required]
        public double SalePirce { get; set; }

        [Required]
        public double KdvRate { get; set; }

        [Required]
        public double ProfitRate { get; set; }

        public virtual List<Product> Products { get; set; }
        public virtual List<Order> Orders { get; set; }
    }
}