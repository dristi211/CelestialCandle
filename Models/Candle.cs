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

        [StringLength(60, MinimumLength = 3)]   //menimum length 3 and maximum 60
        [Required]
        public string Name { get; set; }


        [Display(Name = "Manufacture Date")]
        [DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{yyyy-MM-dd:0}", ApplyFormatInEditMode = true)]
        public DateTime ManufactureDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        public string Size { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Colour { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [StringLength(10)]                            //here string length reuired at least 10 
        [Required]
        public string Fragrance { get; set; }

        [Display(Name = "Melting Point")]       //this will required and string length sould be at least 3
        [StringLength(3)]
        [Required]
        public string MeltingPoint { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Material { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")] //reguler expression will keep it within thr range
        [StringLength(5)]
        [Required]
        public string Rating { get; set; }


        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

       
    }

}

