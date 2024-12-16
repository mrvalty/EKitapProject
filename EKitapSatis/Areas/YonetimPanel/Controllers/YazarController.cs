using EKitap.App.Services.YazarService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EKitapSatis.Areas.YonetimPanel.Controllers;

[Area("YonetimPanel")]
[Authorize(Roles = "Yonetici")]
public class YazarController : Controller
{
    private readonly IYazarService _yazarService;

    public YazarController(IYazarService yazarService)
    {
        _yazarService = yazarService;
    }

    public IActionResult Index()
    {
        return View();
    }

    public async Task<IActionResult> YazarListesi()
    {
        var result = await _yazarService.YazarListele();
        return View(result);
    }

    [HttpPost]
    public async Task<IActionResult> YazarEkle()
    {
        return View();
    }

    [HttpDelete]
    public async Task<IActionResult> YazarSil(int id)
    {
        var result = _yazarService.YazarSil(id);

        return View(result);
    }
}
