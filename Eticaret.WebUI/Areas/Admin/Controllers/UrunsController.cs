using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Eticaret.Core.Entities;
using Eticaret.Data;
using Eticaret.WebUI.araclar;

namespace Eticaret.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UrunsController : Controller
    {
        private readonly DatabaseContext _context;

        public UrunsController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: Admin/Uruns
        public async Task<IActionResult> Index()
        {
            var databaseContext = _context.Urunler.Include(u => u.Kategori).Include(u => u.Marka);
            return View(await databaseContext.ToListAsync());
        }

        // GET: Admin/Uruns/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var urun = await _context.Urunler
                .Include(u => u.Kategori)
                .Include(u => u.Marka)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (urun == null)
            {
                return NotFound();
            }

            return View(urun);
        }

        // GET: Admin/Uruns/Create
        public IActionResult Create()
        {
            ViewData["KategoriId"] = new SelectList(_context.Kategoriler, "Id", "Kategoriİsim");
            ViewData["MarkaId"] = new SelectList(_context.Markalar, "Id", "Markaİsim");
            return View();
        }

        // POST: Admin/Uruns/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Urun urun, IFormFile? Resim)
        {
            if (ModelState.IsValid)
            {
                urun.Resim = await FileHelper.FileLoaderAsync(Resim, "/Img/Urunler/");
                _context.Add(urun);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["KategoriId"] = new SelectList(_context.Kategoriler, "Id", "Kategoriİsim", urun.KategoriId);
            ViewData["MarkaId"] = new SelectList(_context.Markalar, "Id", "Markaİsim", urun.MarkaId);
            return View(urun);
        }

        // GET: Admin/Uruns/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var urun = await _context.Urunler.FindAsync(id);
            if (urun == null)
            {
                return NotFound();
            }
            ViewData["KategoriId"] = new SelectList(_context.Kategoriler, "Id", "Kategoriİsim", urun.KategoriId);
            ViewData["MarkaId"] = new SelectList(_context.Markalar, "Id", "Markaİsim", urun.MarkaId);
            return View(urun);
        }

        // POST: Admin/Uruns/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,  Urun urun, IFormFile? Resim)
        {
            if (id != urun.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(urun);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UrunExists(urun.Id))
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
            ViewData["KategoriId"] = new SelectList(_context.Kategoriler, "Id", "Kategoriİsim", urun.KategoriId);
            ViewData["MarkaId"] = new SelectList(_context.Markalar, "Id", "Markaİsim", urun.MarkaId);
            return View(urun);
        }

        // GET: Admin/Uruns/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var urun = await _context.Urunler
                .Include(u => u.Kategori)
                .Include(u => u.Marka)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (urun == null)
            {
                return NotFound();
            }

            return View(urun);
        }

        // POST: Admin/Uruns/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var urun = await _context.Urunler.FindAsync(id);
            if (urun != null)
            {
                _context.Urunler.Remove(urun);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UrunExists(int id)
        {
            return _context.Urunler.Any(e => e.Id == id);
        }
    }
}
