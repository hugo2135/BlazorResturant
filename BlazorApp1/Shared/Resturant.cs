using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp1.Shared
{
    public class Resturant
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public string Style { get; set; } = String.Empty;
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; } = 0;
        public double Distance { get; set; } = 0;
        public string Address { get; set; } = String.Empty;
        public double Rating { get; set; } = 0;
        public string ImageURL { get; set; } = String.Empty;

        private enum PriceClass
        {
            Cheap = 150,
            Midean = 300
        }

        public string PriceLabel(decimal Price)
        {
            if (Price <= (int)PriceClass.Cheap)
                return "Cheap";
            else if (Price <= (int)PriceClass.Midean)
                return "Midean";
            else if (Price > (int)PriceClass.Midean)
                return "Expensive";
            else
                return "Error";
        }
    }
}
