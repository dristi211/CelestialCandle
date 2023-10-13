using System;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CelestialCandle.Models
{
    public class CandleSizeViewModel
    {
        public List<Candle> Candles { get; set; }  //created the property size as a search criteria
        public SelectList Sizes { get; set; }
        public string CandleSize { get; set; }  //before tried to use Material...wont work for some reasone
        public string SearchString { get; set; }
    }
}
