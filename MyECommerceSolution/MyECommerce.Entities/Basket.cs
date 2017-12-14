using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyECommerce.Entities
{
    [Table("Baskets")]
    public class Basket : NeededUsername
    {
        public virtual List<BasketProduct> BasketProducts { get; set; }
        public virtual User Owner { get; set; }
    }
}
