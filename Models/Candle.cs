using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

namespace CelestialCandle.Models
{
    public class Candle
    {
        public int Id { get; set; }
        public string Name { get; set; }


        [Display(Name = "Manufacture Date")]
        [DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{yyyy-MM-dd:0}", ApplyFormatInEditMode = true)]
        public DateTime ManufactureDate { get; set; }
        public string Size { get; set; }
        public string Colour { get; set; }
        public string Fragrance { get; set; }

        [Display(Name = "Melting Point")]
        public string MeltingPoint { get; set; }
        public string Material { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
    }

}

