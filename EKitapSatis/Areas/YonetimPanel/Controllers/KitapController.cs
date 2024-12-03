using AutoMapper;
using EKitap.App.Models.DTOs.Kitap;
using EKitap.App.Services.KategoriService;
using EKitap.App.Services.KitapService;
using EKitap.App.Services.KullaniciService;
using EKitap.App.Services.YayinEviService;
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

        private readonly IYayinEviService _yayinEviService;

        public KitapController(IKategoriService kategoriService, IYazarService yazarService, IKitapService kitapService, IKullaniciService kullaniciService, IMapper mapper, IYayinEviService yayinEviService)
        {
            _kategoriService = kategoriService;
            _yazarService = yazarService;
            _kitapService = kitapService;
            _kullaniciService = kullaniciService;
            _mapper = mapper;
            _yayinEviService = yayinEviService;
        }

        [HttpGet]
        public async Task<IActionResult> KitapListesi()
        {
            return View(await _kitapService.KitapListesi());
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

                return RedirectToAction("KitapListesi", "Kitap", new { area = "YonetimPanel" });

            }

            KitapEklemeEkrani_VM kitapEkleme_VM = new KitapEklemeEkrani_VM();
            kitapEkleme_VM.Kategoriler = new SelectList(await _kategoriService.TumKategorilerAsync(), "KategoriID", "KategoriAdi");
            kitapEkleme_VM.Yazarlar = new SelectList(await _yazarService.TumMarkalarAsync(), "YazarID", "YazarAdi");

            return View(kitapEkleme_VM);
        }

        [HttpGet]
        public async Task<IActionResult> YazarListesi()
        {
            var result = await _yazarService.YazarListele();
            //ViewBag.YazarList = result;
            return Json(result);
        }

        [HttpGet]
        public async Task<IActionResult> KategoriListesi()
        {
            var result = await _kategoriService.KategoriListele();
            //ViewBag.YazarList = result;
            return Json(result);
        }

        [HttpGet]
        public async Task<IActionResult> YayinEviListesi()
        {
            var result = await _yayinEviService.YayinEviListele();
            //ViewBag.YazarList = result;
            return Json(result);
        }

        [HttpGet("getKitapId/{id}")]
        public async Task<IActionResult> KitapById(int id)
        {
            var result = await _kitapService.UrunDetayGetirAsync(id);
            return Json(result);
        }

        [HttpPost]
        public async Task<IActionResult> KitapGuncelle(KitapEkle_DTO kitap)
        {
            var result = _kitapService.KitapGuncelle(kitap);
            TempData["GuncellemeBasarili"] = "Guncelleme Islemi Basarili";
            return RedirectToAction("KitapListesi", "Kitap", new { area = "YonetimPanel" });
        }

        [HttpDelete]
        public async Task<IActionResult> KitapSil(int id)
        {
            var result = _kitapService.KitapSil(id);

            return View(result);
        }

    }
}
