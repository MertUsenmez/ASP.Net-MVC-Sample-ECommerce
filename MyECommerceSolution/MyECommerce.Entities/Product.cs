using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyECommerce.Entities
{
    [Table("Products")]
    public class Product : MyEntityBase
    {
        [Required, StringLength(50)]
        public string Title { get; set; }

        [StringLength(300)]
        public string Description { get; set; }

        [Required]
        public int StockCount { get; set; }

        [Required]
        public int LikeCount { get; set; }

        [Required]
        public int CategoryId { get; set; }

        public virtual List<Command> Comments { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual Category Category { get; set; }
        public virtual List<ProductPictures> ProductPictures { get; set; }
        public virtual ProductPrice ProductPrice { get; set; }
        public virtual Campaigns Campaigns { get; set; }
        public virtual User Owner { get; set; }
        public virtual List<OrderProduct> Orders { get; set; }
        public virtual List<Liked> Likes { get; set; }
        public virtual  Stock Stock { get; set; }
        public virtual List<BasketProduct> BasketProduct { get; set; }

    }
}
