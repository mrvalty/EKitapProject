using EKitap.App.Models.DTOs.YayinEvi;
using EKitap.Inf.DATA;

namespace EKitap.App.Services.YayinEviService;
public class YayinEviService : IYayinEviService
{
    EKitapSatısDB _context = new();
    public async Task<List<YayinEvi_DTO>> YayinEviListele()
    {
        var result = (from yayin in _context.YayinEvleri
                      select new YayinEvi_DTO
                      {
                          YayinEviID = yayin.YayinEviID,
                          YayinEviAdi = yayin.YayinEviAd
                      }).ToList();
        return result;
    }
}
