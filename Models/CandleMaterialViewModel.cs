using Microsoft.AspNetCore.Mvc.Rendering;
//using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

namespace CelestialCandle.Models
{
    public class CandleMaterialModel
    {
        public List<Candle> Candles { get; set; }
        public SelectList Materials { get; set; }
        public string CandleMaterial { get; set; }
        public string SearchString { get; set; }
    }
}
