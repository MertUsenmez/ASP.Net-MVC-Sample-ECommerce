using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyECommerce.Entities
{
    [Table("Commands")]
    public class Command : NeededUsername
    {
        [Required, StringLength(400)]
        public string Text { get; set; }

        public virtual Product Product { get; set; }
        public virtual User Owner { get; set; }
    }
}
