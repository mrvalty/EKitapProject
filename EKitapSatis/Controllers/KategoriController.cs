using EKitap.App.Services.KategoriService;
using Microsoft.AspNetCore.Mvc;

namespace EKitapSatis.Controllers;
public class KategoriController : Controller
{

    private readonly IKategoriService _kategoriService;

    public KategoriController(IKategoriService kategoriService)
    {
        _kategoriService = kategoriService;
    }

    //public IActionResult KategoriListesi()
    //{
    //    return View();
    //}

    [HttpGet]
    public async Task<IActionResult> KategoriListesi()
    {
        var result = _kategoriService.GetAll();

        if (result != null)
        {
            ViewData["KategoriListesi"] = result;
        }

        return View();
    }
}
