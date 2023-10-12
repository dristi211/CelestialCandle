using System;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CelestialCandle.Models
{
    public class CandleSizeViewModel
    {
        public List<Candle> Candles { get; set; }
        public SelectList Sizes { get; set; }
        public string CandleSize { get; set; }
        public string SearchString { get; set; }
    }
}
