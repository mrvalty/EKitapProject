using EKitap.App.Services.YayinEviService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EKitapSatis.Areas.YonetimPanel.Controllers
{
    [Area("YonetimPanel")]
    [Authorize(Roles = "Yonetici")]
    public class YayinEviController : Controller
    {
        private readonly IYayinEviService _yayinEviService;

        public YayinEviController(IYayinEviService yayinEviService)
        {
            _yayinEviService = yayinEviService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> YayinEviListesi()
        {
            var result = await _yayinEviService.YayinEviListele();
            return View(result);
        }
        [HttpDelete]
        public async Task<IActionResult> YayinEviSil(int id)
        {
            var result = _yayinEviService.YayinEviSil(id);

            return View(result);
        }

    }
}
