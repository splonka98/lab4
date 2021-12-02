using System;
using System.Collections.Generic;
using System.ComponentModel;
<<<<<<< HEAD
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
=======
>>>>>>> 8dbd5308708360f24b0600f82a4b4ff28512741b
using System.Linq;
using System.Threading.Tasks;

namespace Shoping.Models
{
<<<<<<< HEAD
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
=======
    public class ShopingModel
    {
        public int ProductId { get; set; }

        [DisplayName ("Nazwa")]
        public string Name { get; set; }
        [DisplayName("Ilość")]
        public int Quantity { get; set; }
        [DisplayName("Opis")]
>>>>>>> 8dbd5308708360f24b0600f82a4b4ff28512741b
        public string Description { get; set; }

        public bool Bought { get; set; }
    }
}
