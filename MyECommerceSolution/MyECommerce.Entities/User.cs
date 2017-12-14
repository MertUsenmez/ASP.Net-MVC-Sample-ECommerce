using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyECommerce.Entities
{
    [Table("Users")]
    public class User : MyEntityBase
    {
        [Required, StringLength(25)]
        public string Name { get; set; }

        [Required, StringLength(25)]
        public string Surname { get; set; }

        [Required, StringLength(25)]
        public string Username { get; set; }

        [Required, StringLength(100)]
        public string Password { get; set; }

        [Required, StringLength(150)]
        public string EMail { get; set; }

        public bool IsActive { get; set; }
        public bool IsAdmin { get; set; }

        [Required]
        public Guid ActiveGuid { get; set; }

        [Required, StringLength(20)]
        public string Country { get; set; }

        [Required, StringLength(20)]
        public string City { get; set; }

        [Required, StringLength(255)]
        public string Address { get; set; }

        [Required, StringLength(14)]
        public string Phone { get; set; }

        [StringLength(14)]
        public string AdditionalPhone { get; set; }

        public virtual List<Product> Products { get; set; }
        public virtual List<Order> Orders { get; set; }
        public virtual List<Command> Comments { get; set; }
        public virtual List<Liked> Likes { get; set; }
        public virtual List<Basket> Baskets { get; set; }



    }
}
