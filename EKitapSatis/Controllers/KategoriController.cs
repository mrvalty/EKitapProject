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
        //var result = _kategoriService.KategoriListele();
        var result = _kategoriService.GetAll();
        //if (result != null)
        //{
        //    ViewData["KategoriListesi"] = result;
        //}
        return Json(result);
    }

    [HttpPost]
    public async Task<IActionResult> KategoriyeGoreKitapGetir(int id)
    {
        var result = _kategoriService.KategoriyeGoreKitap(id);
        return Json(result);
    }

    [Route("Kategori/KategoriKitapListesi")]
    public IActionResult KategoriKitapListesi()
    {
        return View();
    }

}
