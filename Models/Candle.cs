using System;
using System.ComponentModel.DataAnnotations;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

namespace CelestialCandle.Models
{
    public class Candle
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{yyyy-MM-dd:0}", ApplyFormatInEditMode = true)]
        public DateTime ManufactureDate { get; set; }
        public string Size { get; set; }
        public string Colour { get; set; }
        public string Fragrance { get; set; }
        public string MeltingPoint { get; set; }
        public string Material { get; set; }
        public decimal Price { get; set; }
    }

}

