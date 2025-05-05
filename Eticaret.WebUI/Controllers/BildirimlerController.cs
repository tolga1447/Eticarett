using Eticaret.Core.Entities;
using Eticaret.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Eticaret.WebUI.Controllers
{
    public class BildirimlerController : Controller
    {
        //private readonly DatabaseContext _context;

        //public BildirimlerController(DatabaseContext context)
        //{
        //    _context = context;
        //}
        private readonly IServices<Bildirim> _service;

        public BildirimlerController(IServices<Bildirim> service)
        {
            _service = service;
        }
        public async Task<IActionResult> IndexAsync()
        {
            return View(await _service.GetAllAsync());
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bildirim = await _service
                .GetAsync(m => m.Id == id);
            if (bildirim == null)
            {
                return NotFound();
            }

            return View(bildirim);
        }
    }
}
