using Eticaret.Core.Entities;
using Eticaret.Services.Abstract;
using Eticaret.Services.Concrete;
using Eticaret.WebUI.ExtensionMethods;
using Eticaret.WebUI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Eticaret.WebUI.Controllers
{
    public class SepetController : Controller
    {
        private readonly IServices<Urun> _service;

        public SepetController(IServices<Urun> service)
        {
            _service = service;
        }
        public IActionResult Index()
        {
            var sepet = GetSepet();
            var model = new SepetViewModel()
            {
                sepetLines = sepet.SepetLines,
                ToplamFiyat = sepet.ToplamFiyat()
            };
            return View(model);
        }
        public IActionResult Add(int UrunId, int Quantity = 1)
        {
            var urun = _service.Find(UrunId);
            if (urun != null)
            {
                var sepet = GetSepet();
                sepet.AddUrun(urun,Quantity);
                HttpContext.Session.SetJson("Sepet",sepet);
                return Redirect(Request.Headers["Referer"].ToString());
            }
            return RedirectToAction("Index");
        }
        public IActionResult Update(int UrunId, int Quantity = 1)
        {
            var urun = _service.Find(UrunId);
            if (urun != null)
            {
                var sepet = GetSepet();
                sepet.UpdateUrun(urun,Quantity);
                HttpContext.Session.SetJson("Sepet",sepet);
            }
            return RedirectToAction("Index");
        }
        public IActionResult Remove(int UrunId)
        {
            var urun = _service.Find(UrunId);
            if (urun != null)
            {
                var sepet = GetSepet();
                sepet.RemoveUrun(urun);
                HttpContext.Session.SetJson("Sepet",sepet);
            }
            return RedirectToAction("Index");
        }
        [Authorize]
        public IActionResult CheckOut()
        {
            var sepet = GetSepet();
            var model = new CheckoutViewModel()
            {
                SepetUrun = sepet.SepetLines,
                ToplamFiyat = sepet.ToplamFiyat()
            };
            return View(model);
        }
        private SepetService GetSepet()
        {
            return HttpContext.Session.GetJson<SepetService>("Sepet") ?? new SepetService();
        }

    }
}
