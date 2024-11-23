using AutoMapper;
using EKitap.App.Models.DTOs.Kullanici;
using EKitap.App.Services.KullaniciService;
using EKitap.Domain.Models;
using EKitapSatis.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EKitapSatis.Controllers
{
    public class KullaniciController : Controller
    {
        private readonly IKullaniciService _kullaniciService;
        private readonly IMapper _mapper;
        private readonly SignInManager<Kullanici> _signInManager;

        public KullaniciController(IKullaniciService kullaniciService, IMapper mapper, SignInManager<Kullanici> signInManager)
        {
            _kullaniciService = kullaniciService;
            _mapper = mapper;
            _signInManager = signInManager;
        }

        public IActionResult KullaniciEkle()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> KullaniciEkle(KullaniciEkle_VM kullanici)
        {

            bool EklemeIslemiBasarilimi = false;
            if (ModelState.IsValid)
            {
                KullaniciEkle_DTO yeniKullanici = new KullaniciEkle_DTO();

                _mapper.Map(kullanici, yeniKullanici);

                EklemeIslemiBasarilimi = await _kullaniciService.YeniKullaniciEkleAsync(yeniKullanici);
            }

            if (EklemeIslemiBasarilimi)
                return RedirectToAction("UyeGiris");

            ModelState.AddModelError("Hata", "Kullanıcı oluşturulamadi...");
            return View();
        }

        public IActionResult KullaniciGiris()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> KullaniciGiris(KullaniciGiris_DTO login)
        {
            if (ModelState.IsValid)
            {
                var user = await _kullaniciService.KullaniciGirisAsync(login);
                bool isAdmin = false;
                bool isKullanici = false;
                if (user != null)
                {

                    await _signInManager.SignInAsync(user, false);
                    isAdmin = User.IsInRole("Yonetici");
                    isKullanici = User.IsInRole("Kullanici");
                    if (isAdmin)
                    {
                        return RedirectToAction("Index", "YonetimPanel", new { area = "YonetimPanel" });

                    }
                    else if (isKullanici)
                    {
                        return RedirectToAction("Anasayfa", "KullaniciPanel", new { area = "KullaniciPanel" });
                    }
                }
                return RedirectToAction("IndexHome", "Home");

            }
            return View();

        }

        [HttpPost]
        public async Task<IActionResult> KullaniciCikis()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("UyeGiris", "Uye");
        }

    }
}

