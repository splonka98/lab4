using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Shoping.Models
{
    public class ShopingModel
    {
        public int ProductId { get; set; }

        [DisplayName ("Nazwa")]
        public string Name { get; set; }
        [DisplayName("Ilość")]
        public int Quantity { get; set; }
        [DisplayName("Opis")]
        public string Description { get; set; }

        public bool Bought { get; set; }
    }
}
