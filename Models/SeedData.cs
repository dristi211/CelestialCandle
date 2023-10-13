using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CelestialCandle.Data;
using System;
using System.Linq;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

namespace CelestialCandle.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CelestialCandleContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<CelestialCandleContext>>()))
            {
                // Look for any movies.
                if (context.Candle.Any())
                {
                    return;   // DB has been seeded
                }

                context.Candle.AddRange(
                    new Candle
                    {
                        Name = "Heavenly",
                        ManufactureDate = DateTime.Parse("1999-02-12"),
                        Size = "Medium",
                        Colour = "Red",
                        Fragrance = "Mild",
                        MeltingPoint = "37C",
                        Material = "Natural Wax",
                        Rating = "Good",
                        Price = 7.99M
                    },

                    new Candle
                    {
                        Name = "Divine",
                        ManufactureDate = DateTime.Parse("2000-12-12"),
                        Size = "Medium",
                        Colour = "Blue",
                        Fragrance = "Strong",
                        MeltingPoint = "62C",
                        Material = "BeesWax",
                        Rating = "Excellent",
                        Price = 9.99M
                    },

                    new Candle
                    {
                        Name = "Holystic",
                        ManufactureDate = DateTime.Parse("1980-03-12"),
                        Size = "Large",
                        Colour = "Yelllow",
                        Fragrance = "Strong",
                        MeltingPoint = "37C",
                        Material = "Patrolium Wax",
                        Rating = "Best",
                        Price = 7.99M
                    },

                    new Candle
                    {
                        Name = "Cosmic",
                        ManufactureDate = DateTime.Parse("1990-02-12"),
                        Size = "Small",
                        Colour = "Aquamarine",
                        Fragrance = "Mild",
                        MeltingPoint = "64C",
                        Material = "BeesWax",
                        Rating = "Best",
                        Price = 9.99M
                    },
                      new Candle
                      {
                          Name = "Cosmic2",
                          ManufactureDate = DateTime.Parse("1992-04-12"),
                          Size = "Medium",
                          Colour = "Beige",
                          Fragrance = "Strong",
                          MeltingPoint = "62C",
                          Material = "BeesWax",
                          Rating = "Good",
                          Price = 12.99M
                      },

                      new Candle
                      {
                          Name = "Cosmic3",
                          ManufactureDate = DateTime.Parse("1996-02-05"),
                          Size = "Large",
                          Colour = "Turquoise",
                          Fragrance = "Strong",
                          MeltingPoint = "64C",
                          Material = "BeesWax",
                          Rating = "Good",
                          Price = 15.99M
                      },
                      new Candle
                      {
                          Name = "Stellar",
                          ManufactureDate = DateTime.Parse("2000-12-12"),
                          Size = "Medium",
                          Colour = "Gold",
                          Fragrance = "Mild",
                          MeltingPoint = "37C",
                          Material = "Petrolium Wax",
                          Rating = "Poor",
                          Price = 15.99M
                      },
                      new Candle
                      {
                          Name = "Angelic",
                          ManufactureDate = DateTime.Parse("2000-12-12"),
                          Size = "Medium",
                          Colour = "Green",
                          Fragrance = "Mild",
                          MeltingPoint = "37C",
                          Material = "Petrolium Wax",
                          Rating = "Best",
                          Price = 19.99M
                      },
                      new Candle
                      {
                          Name = "Sky",
                          ManufactureDate = DateTime.Parse("2001-10-12"),
                          Size = "Small",
                          Colour = "Sky Blue",
                          Fragrance = "Mild",
                          MeltingPoint = "62C",
                          Material = "BeesWax",
                          Rating = "Good",
                          Price = 15.99M
                      },
                      new Candle
                      {
                          Name = "Sky2",
                          ManufactureDate = DateTime.Parse("2001-12-12"),
                          Size = "Medium",
                          Colour = "Dark Blue",
                          Fragrance = "Strong",
                          MeltingPoint = "62C",
                          Material = "BeesWax",
                          Rating = "Good",
                          Price = 15.99M
                      }
                );
                context.SaveChanges();
            }
        }
    }
}

