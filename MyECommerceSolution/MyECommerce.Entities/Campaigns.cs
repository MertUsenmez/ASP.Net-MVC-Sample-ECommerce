using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyECommerce.Entities
{
    [Table("Campaigns")]
    public class Campaigns : MyEntityBase
    {
        [Required]
        public double DiscountRate { get; set; }

        [Required, StringLength(50)]
        public string Title { get; set; }

        [StringLength(100)]
        public string Description { get; set; }

        [Required]
        public string Picture { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}
