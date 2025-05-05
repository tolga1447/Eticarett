using Eticaret.Core.Entities;
using Eticaret.Data;
using Eticaret.Services.Abstract;
using Eticaret.WebUI.ExtensionMethods;
using Microsoft.AspNetCore.Mvc;

namespace Eticaret.WebUI.Controllers
{
    public class FavorilerController : Controller
    {
    //    private readonly DatabaseContext _context;

    //    public FavorilerController(DatabaseContext context)
    //    {
    //        _context = context;
    //    }
    private readonly IServices<Urun> _service;

    public FavorilerController(IServices<Urun> service)
    {
        _service = service;
    }
    public IActionResult Index()
        {
            var favoriler = GetFavoriler();
            return View(favoriler);
        }

        private List<Urun> GetFavoriler()
        {
            return HttpContext.Session.GetJson<List<Urun>>("GetFavoriler") ?? [];
        }

        public IActionResult Add(int urunId)
        {
            var favoriler = GetFavoriler();
            var urun = _service.Find(urunId);
            if (urun != null && !favoriler.Any(p=>p.Id==urunId))
            {
                favoriler.Add(urun);
                HttpContext.Session.SetJson("GetFavoriler", favoriler);
            }
            return RedirectToAction("Index");
        }

        public IActionResult Remove(int urunId)
        {
            var favoriler = GetFavoriler();
            var urun = _service.Find(urunId);
            if (urun != null && favoriler.Any(p=>p.Id==urunId))
            {
                favoriler.RemoveAll(i=>i.Id == urunId);
                HttpContext.Session.SetJson("GetFavoriler", favoriler);
            }
            return RedirectToAction("Index");
        }
    }
}
