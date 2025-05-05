using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Eticaret.Core.Entities;
using Eticaret.Data;
using Microsoft.AspNetCore.Authorization;

namespace Eticaret.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Policy = "AdminPolicy")]
    public class AdresController : Controller
    {
        private readonly DatabaseContext _context;

        public AdresController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: Admin/Adres
        public async Task<IActionResult> Index()
        {
            var databaseContext = _context.Adresler.Include(a => a.AppUser);
            return View(await databaseContext.ToListAsync());
        }

        // GET: Admin/Adres/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var adres = await _context.Adresler
                .Include(a => a.AppUser)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (adres == null)
            {
                return NotFound();
            }

            return View(adres);
        }

        // GET: Admin/Adres/Create
        public IActionResult Create()
        {
            ViewData["AppUserId"] = new SelectList(_context.AppUsers, "Id", "Email");
            return View();
        }

        // POST: Admin/Adres/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Sehir,İlce,AcikAdres,IsAktif,IsFaturaAdresi,IsTeslimatAdresi,AppUserId")] Adres adres)
        {
            if (ModelState.IsValid)
            {
                _context.Add(adres);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AppUserId"] = new SelectList(_context.AppUsers, "Id", "Email", adres.AppUserId);
            return View(adres);
        }

        // GET: Admin/Adres/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var adres = await _context.Adresler.FindAsync(id);
            if (adres == null)
            {
                return NotFound();
            }
            ViewData["AppUserId"] = new SelectList(_context.AppUsers, "Id", "Email", adres.AppUserId);
            return View(adres);
        }

        // POST: Admin/Adres/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Sehir,İlce,AcikAdres,IsAktif,IsFaturaAdresi,IsTeslimatAdresi,AppUserId")] Adres adres)
        {
            if (id != adres.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(adres);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdresExists(adres.Id))
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
            ViewData["AppUserId"] = new SelectList(_context.AppUsers, "Id", "Email", adres.AppUserId);
            return View(adres);
        }

        // GET: Admin/Adres/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var adres = await _context.Adresler
                .Include(a => a.AppUser)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (adres == null)
            {
                return NotFound();
            }

            return View(adres);
        }

        // POST: Admin/Adres/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var adres = await _context.Adresler.FindAsync(id);
            if (adres != null)
            {
                _context.Adresler.Remove(adres);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AdresExists(int id)
        {
            return _context.Adresler.Any(e => e.Id == id);
        }
    }
}
