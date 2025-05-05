using Eticaret.Core.Entities;
using Eticaret.Services.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Eticaret.WebUI.Controllers
{
    public class KategorilerController : Controller
    {
        //private readonly DatabaseContext _context;

        //public KategorilerController(DatabaseContext context)
        //{
        //    _context = context;
        //}
        private readonly IServices<Kategori> _service;

        public KategorilerController(IServices<Kategori> service)
        {
            _service = service;
        }
        public async Task<IActionResult> IndexAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kategori = await _service.GetQueryable().Include(u=>u.Urunler)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (kategori == null)
            {
                return NotFound();
            }

            return View(kategori);
           
        }
    }
}
