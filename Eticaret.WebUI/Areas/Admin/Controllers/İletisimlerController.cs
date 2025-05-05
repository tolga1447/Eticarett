using Eticaret.Core.Entities;
using Eticaret.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Eticaret.WebUI.Areas.Admin.Controllers
{
    [Area("Admin"), Authorize(Policy = "AdminPolicy")]
    public class İletisimlerController : Controller
    {
        private readonly DatabaseContext _context;

        public İletisimlerController(DatabaseContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var iletisimler = _context.Iletisimler.OrderByDescending(x => x.OlusturmaTarihi).ToList();
            return View(iletisimler);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();

            var contact = await _context.Iletisimler.FirstOrDefaultAsync(m => m.Id == id);

            if (contact == null)
                return NotFound();

            if (!contact.Okundu) // Eğer okunmadıysa okundu yap
            {
                contact.Okundu = true;
                _context.Update(contact);
                await _context.SaveChangesAsync();
            }

            return View(contact);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();

            var contact = await _context.Iletisimler.FindAsync(id);

            if (contact == null)
                return NotFound();

            return View(contact);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Iletisim contact)
        {
            if (id != contact.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(contact);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!İletisimExists(contact.Id))
                        return NotFound();
                    else
                        throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(contact);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var contact = await _context.Iletisimler.FindAsync(id);

            if (contact == null)
                return NotFound();

            return View(contact);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var contact = await _context.Iletisimler.FindAsync(id);
            if (contact != null)
            {
                _context.Iletisimler.Remove(contact);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }

        private bool İletisimExists(int id)
        {
            return _context.Iletisimler.Any(e => e.Id == id);
        }
    }
}
