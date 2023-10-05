using Microsoft.EntityFrameworkCore;
using CelestialCandle.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

namespace CelestialCandle.Data
{
    public class CelestialCandleContext : DbContext
    {
        public CelestialCandleContext(DbContextOptions<CelestialCandleContext> options)
            : base(options)
        {
        }

        public DbSet<Candle> Candle { get; set; }
    }
}
