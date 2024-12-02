using AutoMapper;
using EKitap.App.Services.KategoriService;
using EKitap.App.Services.KitapService;
using EKitap.App.Services.KullaniciService;
using EKitap.App.Services.YazarService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EKitapSatis.Areas.YonetimPanel.Controllers;

[Area("YonetimPanel")]
[Authorize(Roles = "Yonetici")]
public class KategoriController : Controller
{

    private readonly IKategoriService _kategoriService;
    private readonly IYazarService _yazarService;
    private readonly IKitapService _kitapService;
    private readonly IKullaniciService _kullaniciService;
    private readonly IMapper _mapper;

    public KategoriController(IKategoriService kategoriService, IYazarService yazarService, IKitapService kitapService, IKullaniciService kullaniciService, IMapper mapper)
    {
        _kategoriService = kategoriService;
        _yazarService = yazarService;
        _kitapService = kitapService;
        _kullaniciService = kullaniciService;
        _mapper = mapper;
    }

    public IActionResult Index()
    {
        return View();
    }

    public async Task<IActionResult> KategoriListesi()
    {

        var result = await _kategoriService.KategoriListele();

        return View(result);
    }

    [HttpPost]
    public async Task<IActionResult> KategoriEkle()
    {
        return View();
    }

    [HttpDelete]
    public async Task<IActionResult> KategoriSil(int id)
    {
        var result = _kategoriService.KategoriSil(id);

        return View(result);
    }
}
