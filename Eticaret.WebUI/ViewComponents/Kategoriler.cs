using Eticaret.Core.Entities;
using Eticaret.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Eticaret.WebUI.ViewComponents
{
    public class Kategoriler : ViewComponent
    {
        //private readonly DatabaseContext _context;

        //public Kategoriler(DatabaseContext context)
        //{
        //    _context = context;
        //}
        private readonly IServices<Kategori> _service;

        public Kategoriler(IServices<Kategori> service)
        {
            _service = service;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await _service.GetAllAsync(k=>k.Aktif && k.UstMenu));
        }
    }
}
