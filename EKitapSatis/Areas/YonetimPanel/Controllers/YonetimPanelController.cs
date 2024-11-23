using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EKitapSatis.Areas.YonetimPaneli.Controllers
{
    [Area("YonetimPanel")]
    [Authorize(Roles = "Yonetici")]
    public class YonetimPanelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
