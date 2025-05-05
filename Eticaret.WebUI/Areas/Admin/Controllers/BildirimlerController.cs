using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Eticaret.Core.Entities;
using Eticaret.Data;
using Eticaret.WebUI.araclar;
using Microsoft.AspNetCore.Authorization;

namespace Eticaret.WebUI.Areas.Admin.Controllers
{
    [Area("Admin"), Authorize(Policy = "AdminPolicy")]
    public class BildirimlerController : Controller
    {
        private readonly DatabaseContext _context;

        public BildirimlerController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: Admin/Bildirimler
        public async Task<IActionResult> Index()
        {
            return View(await _context.Bildirimler.ToListAsync());
        }

        // GET: Admin/Bildirimler/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bildirim = await _context.Bildirimler
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bildirim == null)
            {
                return NotFound();
            }

            return View(bildirim);
        }

        // GET: Admin/Bildirimler/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Bildirimler/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( Bildirim bildirim, IFormFile? Resim)
        {
            if (ModelState.IsValid)
            {
                bildirim.Resim = await FileHelper.FileLoaderAsync(Resim, "/Img/Bildirimler/");
                _context.Add(bildirim);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bildirim);
        }

        // GET: Admin/Bildirimler/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bildirim = await _context.Bildirimler.FindAsync(id);
            if (bildirim == null)
            {
                return NotFound();
            }
            return View(bildirim);
        }

        // POST: Admin/Bildirimler/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Bildirim bildirim, IFormFile? Resim, bool cbResmiSil = false)
        {
            if (id != bildirim.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if(cbResmiSil)
                        bildirim.Resim = string.Empty;
                    if (Resim is not null)
                        bildirim.Resim = await FileHelper.FileLoaderAsync(Resim, "/Img/Bildirimler/");
                    _context.Update(bildirim);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BildirimExists(bildirim.Id))
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
            return View(bildirim);
        }

        // GET: Admin/Bildirimler/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bildirim = await _context.Bildirimler
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bildirim == null)
            {
                return NotFound();
            }

            return View(bildirim);
        }

        // POST: Admin/Bildirimler/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bildirim = await _context.Bildirimler.FindAsync(id);
            if (bildirim != null)
            {
                if (!string.IsNullOrEmpty(bildirim.Resim))
                {
                    FileHelper.FileRemover(bildirim.Resim, "/Img/Bildirimler/");

                }
                _context.Bildirimler.Remove(bildirim);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BildirimExists(int id)
        {
            return _context.Bildirimler.Any(e => e.Id == id);
        }
    }
}
