using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Shoping.Models
{
    [Table("Products")]
    public class ShopingModel
    {
        [Key]
        public int ProductId { get; set; }

        [DisplayName ("Nazwa")]
        [Required(ErrorMessage ="Nazwa jest wymagana")]
        [MaxLength(50)]
        public string Name { get; set; }
        [DisplayName("Ilość")]
        public int Quantity { get; set; }
        [DisplayName("Uwagi")]
        [MaxLength(2500)]
        public string Description { get; set; }

        public bool Bought { get; set; }
    }
}
