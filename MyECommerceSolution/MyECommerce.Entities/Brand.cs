using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyECommerce.Entities
{
    [Table("Brands")]
    public class Brand : MyEntityBase
    {
        [Required, StringLength(20)]
        public string BrandName { get; set; }

        [StringLength(150)]
        public string Description { get; set; }

        [Required]
        public string BrandLogo { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}
