using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyECommerce.Entities
{
    [Table("Orders")]
    public class Order : NeededUsername
    {
        [Required, StringLength(50)]
        public string OrderDetail { get; set; }

        public virtual User Owner { get; set; }
        public virtual List<OrderProduct> Products { get; set; }
        public virtual ProductPrice ProductPrice { get; set; }
        public virtual Bank Bank { get; set; }
    }
}
