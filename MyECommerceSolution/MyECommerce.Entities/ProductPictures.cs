using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyECommerce.Entities
{
    [Table("ProductPictures")]
    public class ProductPictures : NeededUsername
    {
        [Required, StringLength(600)]
        public string ProductPicturePath { get; set; }

        public Product Product { get; set; }
    }
}
