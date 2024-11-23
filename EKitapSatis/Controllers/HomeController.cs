using AutoMapper;
using EKitap.App.Services.KitapService;
using EKitapSatis.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EKitapSatis.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IKitapService _kitapService;
        private readonly IMapper _mapper;

        public HomeController(ILogger<HomeController> logger, IKitapService kitapService, IMapper mapper)
        {
            _logger = logger;
            _kitapService = kitapService;
            _mapper = mapper;
        }

        public async Task<IActionResult> IndexHome()
        {
            return View();
        }

        public async Task<IActionResult> Index()
        {
            var kitaplar = await _kitapService.TumUrunlerAsync();
            return View(kitaplar);
        }

        public async Task<IActionResult> KitapDetay(int id)
        {
            var kitapDetay = await _kitapService.UrunDetayGetirAsync(id);
            return View(kitapDetay);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
