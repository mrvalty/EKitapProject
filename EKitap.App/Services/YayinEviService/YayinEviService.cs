using AutoMapper;
using EKitap.App.Models.DTOs.YayinEvi;
using EKitap.Dom.Repositories;
using EKitap.Inf.DATA;

namespace EKitap.App.Services.YayinEviService;
public class YayinEviService : IYayinEviService
{
    private readonly IYayinEviRepository _yayinEviRepository;
    private readonly IMapper _mapper;

    EKitapSatısDB _context = new();

    public YayinEviService(IYayinEviRepository yayinEviRepository, IMapper mapper, EKitapSatısDB context)
    {
        _yayinEviRepository = yayinEviRepository;
        _mapper = mapper;
        _context = context;
    }

    public async Task<List<YayinEvi_DTO>> YayinEviListele()
    {
        var result = (from yayin in _context.YayinEvleri
                      select new YayinEvi_DTO
                      {
                          YayinEviID = yayin.YayinEviID,
                          YayinEviAdi = yayin.YayinEviAd,
                          EklenmeTarihi = yayin.EklenmeTarihi,
                          SilmeTarihi = yayin.SilmeTarihi
                      }).ToList();
        return result;
    }

    public async Task YayinEviSil(int id)
    {
      await _yayinEviRepository.SilAsync(id);
    }
}
