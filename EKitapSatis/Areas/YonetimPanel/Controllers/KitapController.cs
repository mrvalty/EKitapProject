using AutoMapper;
using EKitap.App.Models.DTOs.Kitap;
using EKitap.App.Services.KategoriService;
using EKitap.App.Services.KitapService;
using EKitap.App.Services.KullaniciService;
using EKitap.App.Services.YazarService;
using EKitapSatis.Models.ViewModels;
using EKitapSatis.Utilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EKitapSatis.Areas.YonetimPaneli.Controllers
{
    [Area("YonetimPanel")]
    [Authorize(Roles = "Yonetici")]
    public class KitapController : Controller
    {
        private readonly IKategoriService _kategoriService;
        private readonly IYazarService _yazarService;
        private readonly IKitapService _kitapService;
        private readonly IKullaniciService _kullaniciService;
        private readonly IMapper _mapper;

        public KitapController(IKategoriService kategoriService, IYazarService yazarService, IKitapService kitapService, IKullaniciService kullaniciService, IMapper mapper)
        {
            _kategoriService = kategoriService;
            _yazarService = yazarService;
            _kitapService = kitapService;
            _kullaniciService = kullaniciService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }

        public async Task<IActionResult> KitapListesi()
        {
            return View(await _kitapService.TumUrunlerAsync());
        }
        public async Task<IActionResult> KitapEkle()
        {
            KitapEklemeEkrani_VM kitapEkleme_VM = new KitapEklemeEkrani_VM();
            kitapEkleme_VM.Kategoriler = new SelectList(await _kategoriService.TumKategorilerAsync(), "KategoriID", "KategoriAdi");
            kitapEkleme_VM.Yazarlar = new SelectList(await _yazarService.TumMarkalarAsync(), "YazarID", "YazarAdi");

            return View(kitapEkleme_VM);
        }
        [HttpPost]
        public async Task<IActionResult> KitapEkle(KitapEkle_VM kitap)
        {
            if (ModelState.IsValid)
            {
                KitapEkle_DTO yeniKitap = new KitapEkle_DTO();
                _mapper.Map(kitap, yeniKitap);
                yeniKitap.KitapResmi = await DosyaIslemleri.DosyaKaydetAsync(kitap.KitapResmi);
                yeniKitap.KullaniciID = await _kullaniciService.KullaniciIDGetirAsync(User);

                await _kitapService.UrunEkleAsync(yeniKitap);

                return RedirectToAction("Index", "YonetimPanel", new { area = "YonetimPanel" });

            }

            KitapEklemeEkrani_VM kitapEkleme_VM = new KitapEklemeEkrani_VM();
            kitapEkleme_VM.Kategoriler = new SelectList(await _kategoriService.TumKategorilerAsync(), "KategoriID", "KategoriAdi");
            kitapEkleme_VM.Yazarlar = new SelectList(await _yazarService.TumMarkalarAsync(), "YazarID", "YazarAdi");

            return View(kitapEkleme_VM);
        }
    }
}
