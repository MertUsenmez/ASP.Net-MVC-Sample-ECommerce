using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyECommerce.Entities
{
    [Table("Stocks")]
    public class Stock : MyEntityBase
    {
        [Required]
        public int Piece { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}
