using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CelestialCandle.Data;
using CelestialCandle.Models;

namespace CelestialCandle.Controllers
{
    public class CandlesController : Controller
    {
        private readonly CelestialCandleContext _context;

        public CandlesController(CelestialCandleContext context)
        {
            _context = context;
        }

        // GET: Candles
        // GET: Movies
        public async Task<IActionResult> Index(string candleMaterial, string searchString)
        {
            // Use LINQ to get list of genres.
            IQueryable<string> genreQuery = from m in _context.Candle
                                            orderby m.Material
                                            select m.Material;

            var movies = from m in _context.Candle
                         select m;

            if (!string.IsNullOrEmpty(searchString)) //adding search string if there is Null or empty fild
            {
                movies = movies.Where(s => s.Name.Contains(searchString));
            }

            if (!string.IsNullOrEmpty(candleMaterial))
            {
                movies = movies.Where(x => x.Material == candleMaterial);
            }

            var candleMaterialVM = new CandleMaterialViewModel
            {
                Materials = new SelectList(await genreQuery.Distinct().ToListAsync()),
                Candles = await movies.ToListAsync()
            };

            return View(candleMaterialVM);
        }

        // GET: Candles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var candle = await _context.Candle
                .FirstOrDefaultAsync(m => m.Id == id);
            if (candle == null)
            {
                return NotFound();
            }

            return View(candle);
        }

        // GET: Candles/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Candles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,ManufactureDate,Size,Colour,Fragrance,MeltingPoint,Material,Price")] Candle candle)
        {
            if (ModelState.IsValid)
            {
                _context.Add(candle);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(candle);
        }

        // GET: Candles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var candle = await _context.Candle.FindAsync(id);
            if (candle == null)
            {
                return NotFound();
            }
            return View(candle);
        }

        // POST: Candles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,ManufactureDate,Size,Colour,Fragrance,MeltingPoint,Material,Price")] Candle candle)
        {
            if (id != candle.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(candle);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CandleExists(candle.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(candle);
        }

        // GET: Candles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var candle = await _context.Candle
                .FirstOrDefaultAsync(m => m.Id == id);
            if (candle == null)
            {
                return NotFound();
            }

            return View(candle);
        }

        // POST: Candles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var candle = await _context.Candle.FindAsync(id);
            _context.Candle.Remove(candle);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CandleExists(int id)
        {
            return _context.Candle.Any(e => e.Id == id);
        }
    }

    internal class CandleMaterialViewModel
    {
        public SelectList Materials { get; set; }
        public List<Candle> Candles { get; set; }
    }
}
