using Microsoft.AspNetCore.Mvc;

namespace EKitapSatis.Controllers;
public class UrunController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult UrunDetay()
    {
        return View();
    }
}
