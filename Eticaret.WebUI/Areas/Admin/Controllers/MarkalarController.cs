using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Eticaret.Core.Entities;
using Eticaret.Data;
using Eticaret.WebUI.araclar;
using Microsoft.AspNetCore.Authorization;

namespace Eticaret.WebUI.Areas.Admin.Controllers
{
    [Area("Admin"), Authorize(Policy = "AdminPolicy")]
    public class MarkalarController : Controller
    {
        private readonly DatabaseContext _context;

        public MarkalarController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: Admin/Markalar
        public async Task<IActionResult> Index()
        {
            return View(await _context.Markalar.ToListAsync());
        }

        // GET: Admin/Markalar/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var marka = await _context.Markalar
                .FirstOrDefaultAsync(m => m.Id == id);
            if (marka == null)
            {
                return NotFound();
            }

            return View(marka);
        }

        // GET: Admin/Markalar/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Markalar/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( Marka marka, IFormFile? Logo)
        {
            if (ModelState.IsValid)
            {
                marka.Logo = await FileHelper.FileLoaderAsync(Logo);
                _context.Add(marka);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(marka);
        }

        // GET: Admin/Markalar/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var marka = await _context.Markalar.FindAsync(id);
            if (marka == null)
            {
                return NotFound();
            }
            return View(marka);
        }

        // POST: Admin/Markalar/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,  Marka marka, IFormFile? Logo,bool cbResmiSil = false)
        {
            if (id != marka.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (cbResmiSil)
                        marka.Logo = string.Empty;
                    if (Logo is not null)
                        marka.Logo = await FileHelper.FileLoaderAsync(Logo);
                    _context.Update(marka);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MarkaExists(marka.Id))
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
            return View(marka);
        }

        // GET: Admin/Markalar/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var marka = await _context.Markalar
                .FirstOrDefaultAsync(m => m.Id == id);
            if (marka == null)
            {
                return NotFound();
            }

            return View(marka);
        }

        // POST: Admin/Markalar/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var marka = await _context.Markalar.FindAsync(id);
            if (marka != null)
            {
                if(!string.IsNullOrEmpty(marka.Logo))
                {
                    FileHelper.FileRemover(marka.Logo);
                    
                }
                _context.Markalar.Remove(marka);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MarkaExists(int id)
        {
            return _context.Markalar.Any(e => e.Id == id);
        }
    }
}
