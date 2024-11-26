using AutoMapper;
using EKitap.App.Services.KategoriService;
using EKitap.App.Services.KitapService;
using EKitap.App.Services.KullaniciService;
using EKitap.App.Services.SepetService;
using EKitap.App.Services.YayinEviService;
using EKitap.App.Services.YazarService;
using EKitap.Dom.Repositories;
using EKitap.Domain.Models;
using EKitap.Inf.DATA;
using EKitap.Inf.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//builder.Services.AddApplicationServices();

builder.Services.AddDbContext<EKitapSatýsDB>(x => x.UseSqlServer("DefaultConnection"));

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

//builder.Services.AddIdentity<Kullanici, IdentityRole>()
//    .AddEntityFrameworkStores<EKitapSatýsDB>()
//    .AddDefaultTokenProviders();

builder.Services.AddIdentity<Kullanici, Rol>(x => x.SignIn.RequireConfirmedAccount = false).AddRoles<Rol>()
    .AddEntityFrameworkStores<EKitapSatýsDB>();

builder.Services.AddTransient<IKullaniciService, KullaniciService>();
builder.Services.AddTransient<IKategoriService, KategoriService>();
builder.Services.AddTransient<IKategoriRepository, KategoriRepository>();
builder.Services.AddTransient<IKitapService, KitapService>();
builder.Services.AddTransient<IKitapRepository, KitapRepository>();
builder.Services.AddTransient<ISepetService, SepetService>();
builder.Services.AddTransient<ISepetRepository, SepetRepository>();
builder.Services.AddTransient<IYazarService, YazarService>();
builder.Services.AddTransient<IYazarRepository, YazarRepository>();
builder.Services.AddTransient<IKitapYazarRepository, KitapYazarRepository>();
builder.Services.AddTransient<IYayinEviService, YayinEviService>();



builder.Services.AddTransient<IMapper, Mapper>();


var app = builder.Build();




// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapAreaControllerRoute(
       name: "YonetimPanel",
       areaName: "YonetimPanel",
       pattern: "YonetimPanel/{controller=YonetimPanel}/{action=Index}/{id?}"
       );

    endpoints.MapAreaControllerRoute(
        name: "KullaniciPanel",
        areaName: "KullaniciPanel",
        pattern: "KullaniciPanel/{controller=KullaniciPanel}/{action=Anasayfa}/{id?}"
        );
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=IndexHome}/{id?}");
});

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=IndexHome}/{id?}");

app.Run();
