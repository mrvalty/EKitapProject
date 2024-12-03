using EKitap.App.Services.KullaniciService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EKitapSatis.Areas.YonetimPanel.Controllers;

[Area("YonetimPanel")]
[Authorize(Roles = "Yonetici")]
public class KullaniciController : Controller
{
    private readonly IKullaniciService _kullaniciService;

    public KullaniciController(IKullaniciService kullaniciService)
    {
        _kullaniciService = kullaniciService;
    }

    public IActionResult Index()
    {
        return View();
    }

    public async Task<IActionResult> KullaniciListesi()
    {
        var result = await _kullaniciService.KullaniciListesi();
        return View(result);
    }

    [HttpGet]
    public async Task<IActionResult> KullaniciDetay(int id)
    {
        var result = await _kullaniciService.KullaniciListesi();
        return Json(result);
    }
}
