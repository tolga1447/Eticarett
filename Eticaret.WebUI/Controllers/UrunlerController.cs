using Eticaret.Core.Entities;
using Eticaret.Data;
using Eticaret.Services.Abstract;
using Eticaret.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Eticaret.WebUI.Controllers
{
    public class UrunlerController : Controller
    {
        //private readonly DatabaseContext _context;

        //public UrunlerController(DatabaseContext context)
        //{
        //    _context = context;
        //}
        private readonly IServices<Urun> _service;

        public UrunlerController(IServices<Urun> service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index(string q = "")
        {
            var databaseContext = _service.GetAllAsync(u => u.Aktif && (u.Urunİsim.Contains(q) || u.Aciklama.Contains(q)));
            return View(await databaseContext);
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var urun = await _service.GetQueryable()
                .Include(u => u.Kategori)
                .Include(u => u.Marka)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (urun == null)
            {
                return NotFound();
            }
            var model = new UrunDetailViewModel() { Urun = urun,İliskiliUrunler = _service.GetQueryable().Where(u => u.Aktif && u.KategoriId == urun.KategoriId
            && u.Id != urun.Id) };

            return View(model);
        }
    }

}
