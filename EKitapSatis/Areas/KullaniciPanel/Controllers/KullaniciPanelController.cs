using EKitap.App.Models.DTOs.Sepet;
using EKitap.App.Services.KullaniciService;
using EKitap.App.Services.SepetService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EKitapSatis.Areas.KullaniciPaneli.Controllers
{
    [Area("KullaniciPanel")]
    [Authorize]
    public class KullaniciPanelController : Controller
    {
        private readonly ISepetService _sepetServis;
        private readonly IKullaniciService _kullaniciServis;

        public KullaniciPanelController(ISepetService sepetServis, IKullaniciService kullaniciServis)
        {
            _sepetServis = sepetServis;
            _kullaniciServis = kullaniciServis;
        }
        public IActionResult Anasayfa()
        {
            return View();
        }

        public async Task<IActionResult> Index()
        {
            int kullaniciID = await _kullaniciServis.KullaniciIDGetirAsync(User);
            var sepettekiUrunler = await _sepetServis.SepettekiUrunler(kullaniciID);
            return View(sepettekiUrunler);
        }
        public async Task<IActionResult> SepeteEkle(int id)
        {
            Sepet_DTO sepet_DTO = new Sepet_DTO();
            sepet_DTO.KullaniciID = id;
            sepet_DTO.KullaniciID = await _kullaniciServis.KullaniciIDGetirAsync(User);
            sepet_DTO.Adet = 1;

            await _sepetServis.SepeteEkleAsync(sepet_DTO);

            return NoContent();

        }
    }
}
