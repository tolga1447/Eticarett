<<<<<<< HEAD
﻿using System.Diagnostics;
using Eticaret.Core.Entities;
using Eticaret.Services.Abstract;
=======
using System.Diagnostics;
>>>>>>> 09a4d2ce627413f779d3fe762f02da38c028af23
using Eticaret.WebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Eticaret.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

<<<<<<< HEAD
        //private readonly DatabaseContext _context;

        //public HomeController(DatabaseContext context)
        //{
        //    _context = context;
        //}

        private readonly IServices<Urun> _serviceUrun;
        private readonly IServices<Slider> _serviceSlider;
        private readonly IServices<Bildirim> _serviceBildirimler;
        private readonly IServices<Iletisim> _serviceIletisimler;

        public HomeController(IServices<Urun> serviceProduct, IServices<Slider> serviceSlider, IServices<Bildirim> serviceBildirimler, IServices<Iletisim> serviceIletisimler)
        {
            _serviceUrun = serviceProduct;
            _serviceSlider = serviceSlider;
            _serviceBildirimler = serviceBildirimler;
            _serviceIletisimler = serviceIletisimler;
        }

        public async Task<IActionResult> Index()
        {
            var model = new HomePageViewModel()
            {
                Sliders = await _serviceSlider.GetAllAsync(),
                Urunler = await _serviceUrun.GetAllAsync(u=>u.Aktif && u.AnaSayfa),//anasayfada filtreleme işlemi
                Bildirimler = await _serviceBildirimler.GetAllAsync(),
            };
            return View(model);
=======
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
>>>>>>> 09a4d2ce627413f779d3fe762f02da38c028af23
        }

        public IActionResult Privacy()
        {
            return View();
        }
<<<<<<< HEAD
       
        [Route("AccessDenied")]
        public IActionResult AccessDenied()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();
        }
        [HttpPost]
        public  async Task<IActionResult> ContactUsAsync(Iletisim iletisim)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _serviceIletisimler.AddAsync(iletisim);
                    var sonuc = await _serviceIletisimler.SaveChangesAsync();
                    if (sonuc > 0)
                    {
                        TempData["Message"] = "Mesajınız başarıyla gönderildi!";

                        //await MailHelper.SendMailAsync(iletisim);
                        return RedirectToAction("ContactUs");
                    }
                }
                catch (Exception)
                {

                    ModelState.AddModelError("", "Hata Oluştu!");
                }
            }
            return View(iletisim);
        }
=======
>>>>>>> 09a4d2ce627413f779d3fe762f02da38c028af23

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
