<<<<<<< HEAD
using Eticaret.Data;
using Eticaret.Services.Abstract;
using Eticaret.Services.Concrete;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;

=======
>>>>>>> 09a4d2ce627413f779d3fe762f02da38c028af23
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
<<<<<<< HEAD
builder.Services.AddScoped(typeof(IServices<>),typeof(Services<>));


builder.Services.AddSession(options =>
{
    options.Cookie.Name = ".Eticaret.Session"; // Oturum verilerini saklamak için kullanılacak çerezin (cookie) adı.
    options.Cookie.HttpOnly = true; // çerezin (cookie) sadece HTTP istekleriyle erişilebilir olmasını sağlar (JavaScript erişemez).
    options.Cookie.IsEssential = true;  // Kullanıcının çerezleri kabul etmese bile oturumun çalışmasını sağlar.
    options.IdleTimeout = TimeSpan.FromDays(1);// Kullanıcının oturumu 1 gün boyunca aktif kalır, sonra zaman aşımına uğrar.
    options.IOTimeout = TimeSpan.FromMinutes(10);// (Hatalı bir seçenek) ASP.NET Core'da böyle bir ayar yoktur, kaldırılmalıdır.
});


builder.Services.AddDbContext<DatabaseContext>();
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)//Cookie Ayarlarının Yapılandırılması.
    .AddCookie(x =>
{
    x.LoginPath = "/Account/SignIn";//giriş adresi login
    x.AccessDeniedPath = "/AccessDenied";//erişim izin yeri kullanıcın yetkisi yoksa ret bölgesine atar
    x.Cookie.Name = "Account";
    x.Cookie.MaxAge = TimeSpan.FromDays(7);//kişi en fazla 7 gün oturumunu açık tutabilir.
    x.Cookie.IsEssential = true;//kalıcı cookie
});
builder.Services.AddAuthorization(x =>
{
    x.AddPolicy("AdminPolicy", policy => policy.RequireClaim(ClaimTypes.Role, "Admin"));//sadece admin (Admin paneli)
    x.AddPolicy("UserPolicy", policy => policy.RequireClaim(ClaimTypes.Role, "Admin","User","Customer"));//burdada admin hem user hem admin olarak görüntüleyebilir
});//yetkilendirme authorization
=======
>>>>>>> 09a4d2ce627413f779d3fe762f02da38c028af23

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
<<<<<<< HEAD
app.UseSession();//uygulamada session kullanmızı bildiriyoruz

app.UseAuthentication();// önce oturum açacak.(tam tersi olursa oturum açma işlemi olmayacaktır.)
app.UseAuthorization();//sonra  yetkilendirme.

app.MapControllerRoute(
            name: "admin",
            pattern: "{area:exists}/{controller=Main}/{action=Index}/{id?}"
          );
=======

app.UseAuthorization();
>>>>>>> 09a4d2ce627413f779d3fe762f02da38c028af23

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
