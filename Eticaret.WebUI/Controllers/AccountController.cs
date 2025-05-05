using Eticaret.Core.Entities;
using Eticaret.Services.Abstract;
using Eticaret.WebUI.Models;
using Microsoft.AspNetCore.Authentication;//login
using Microsoft.AspNetCore.Authorization;//login
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;//login

namespace Eticaret.WebUI.Controllers
{
    public class AccountController : Controller
    {
        //private readonly DatabaseContext _context;

        //public AccountController(DatabaseContext context)
        //{
        //    _context = context;
        //}
        private readonly IServices<AppUser> appUser_services;

        public AccountController(IServices<AppUser> appUser_services)
        {
            this.appUser_services = appUser_services;
        }

        [Authorize]
        public  async Task<IActionResult> IndexAsync()
        {
            var kullaniciGuidClaim = HttpContext.User.FindFirst("UserGuid");

            if (kullaniciGuidClaim == null)
            {
                return Unauthorized(); // Claim bulunamazsa 401 hatası döndür.
            }

            AppUser user = await appUser_services.GetAsync(x => x.KullaniciGuid.ToString() == kullaniciGuidClaim.Value);

            if (user is null)
            {
                return NotFound();
            }

            var model = new KullaniciDuzenlemeView()
            {
                Id = user.Id,
                Email = user.Email,
                Sifre = user.Sifre,
                İsim = user.İsim,
                Soyisim = user.Soyisim,
                Telefon = user.Telefon
            };
            return View(model);
        }
        [HttpPost, Authorize]
        public async Task<IActionResult> IndexAsync(KullaniciDuzenlemeView model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var kullaniciGuidClaim = HttpContext.User.FindFirst("UserGuid");
                    AppUser appUser = await appUser_services.GetAsync(x => x.KullaniciGuid.ToString() == kullaniciGuidClaim.Value);
                    AppUser user = appUser;
                    if (user is not null)
                    {
                        user.Soyisim = model.Soyisim;
                        user.İsim = model.İsim;
                        user.Sifre = model.Sifre;
                        user.Email = model.Email;
                        user.Telefon = model.Telefon;

                        appUser_services.Update(user);
                       var sonuc = appUser_services.SaveChanges();

                        if (sonuc > 0)
                        {
                            TempData["Message"] = "Bilgileriniz Güncellenmiştir!";

                            //await MailHelper.SendMailAsync(iletisim);
                            return RedirectToAction("Index");
                        }
                    }
                    
                }
                catch (Exception)
                {

                    ModelState.AddModelError("", "Hata Oluştu!");
                }
            }
            return View(model);
        }
        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignInAsync(LoginViewModel LoginViewModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var account = await appUser_services.GetAsync(x => x.Email == LoginViewModel.Email && x.Sifre == LoginViewModel.Sifre);
                    if (account == null)
                    {
                        ModelState.AddModelError("", "Giriş Başarısız!, Eposta veya Şifre Yanlış. ");
                    }
                    else if (!account.Aktif)
                    {
                        ModelState.AddModelError("", "Bu hesap yasaklandı! Lütfen destek ile iletişime geçin.");
                    }
                    else
                    {
                        var claims = new List<Claim>()
                        {
                            new(ClaimTypes.Name,account.İsim),
                            new(ClaimTypes.Role,account.IsAdmin ? "Admin" : "Customer"),
                            new(ClaimTypes.Email,account.Email),
                            new("UserId", account.Id.ToString()),
                            new("UserGuid", account.KullaniciGuid.ToString()),
                        };
                        var userIdentity = new ClaimsIdentity(claims, "Login");
                        ClaimsPrincipal userPrincipal = new ClaimsPrincipal(userIdentity);
                        await HttpContext.SignInAsync(userPrincipal);

                        //kullanıcının admin olup olmadığını viewdataya atıyoruz
                        ViewData["Isadmin"] = account.IsAdmin;

                        return Redirect(string.IsNullOrEmpty(LoginViewModel.ReturnUrl) ? "/" : LoginViewModel.ReturnUrl);
                    }

                }
                catch (Exception hata)
                {
                    //loglama 
                    ModelState.AddModelError("", "Hata Oluştu!");
                }
            }
            return View();
        }
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost, ActionName("SignUp")]
        public async Task<IActionResult> SignUpAsync(AppUser appUser)
        {
            appUser.IsAdmin = false;
            appUser.Aktif = true;
            if (ModelState.IsValid)
            {
                await  appUser_services.AddAsync(appUser);
                await  appUser_services.SaveChangesAsync();
                return RedirectToAction(nameof(IndexAsync));
            }
            return View(appUser);
        }

        public async Task<IActionResult> SignOutAsync()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("SignIn");
        }
    }
}
