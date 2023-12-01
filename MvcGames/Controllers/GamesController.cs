using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcGames.Models;

namespace MvcGames.Controllers
{
    public class GamesController : Controller
    {
        private readonly MvcGamesContext _context;

        public GamesController(MvcGamesContext context)
        {
            _context = context;
        }

        // GET: Games
        public async Task<IActionResult> Index(string searchString, string searchBy)
        {
            var games = from m in _context.Games select m;

    if (!string.IsNullOrEmpty(searchString))
    {
        if (searchBy == "RELEASEDATE")
        {
            if (DateTime.TryParse(searchString, out var date))
            {
                games = games.Where(g => g.ReleaseDate.Date == date.Date);
            }
        }
        else if (searchBy == "DEVELOPER")
        {
            games = games.Where(g => g.Developer.Contains(searchString));
        }
        else if (searchBy == "PRICE")
        {
            if (decimal.TryParse(searchString, out var price))
            {
                games = games.Where(g => g.Price == price);
            }
        }
    }

    return View(await games.ToListAsync());
}

        // GET: Games/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return View("NotFound");
            }

            var games = await _context.Games
                .FirstOrDefaultAsync(m => m.Id == id);
            if (games == null)
            {
                return View("NotFound");
            }

            return View(games);
        }

        // GET: Games/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Games/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,ReleaseDate,Publisher,Price,Score")] Games games)
        {
            if (ModelState.IsValid)
            {
                _context.Add(games);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(games);
        }

        // GET: Games/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return View("NotFound");
            }

            var games = await _context.Games.FindAsync(id);
            if (games == null)
            {
                return View("NotFound");
            }
            return View(games);
        }

        // POST: Games/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,ReleaseDate,Publisher,Price,Score")] Games games)
        {
            if (id != games.Id)
            {
                return View("NotFound");
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(games);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GamesExists(games.Id))
                    {
                        return View("NotFound");
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(games);
        }

        // GET: Games/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return View("NotFound");
            }

            var games = await _context.Games
                .FirstOrDefaultAsync(m => m.Id == id);
            if (games == null)
            {
                return View("NotFound");
            }

            return View(games);
        }

        // POST: Games/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var games = await _context.Games.FindAsync(id);
            _context.Games.Remove(games);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GamesExists(int id)
        {
            return _context.Games.Any(e => e.Id == id);
        }
    }
}
