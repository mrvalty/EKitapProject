using AutoMapper;
using EKitap.App.Models.DTOs.Yazar;
using EKitap.Dom.Repositories;
using EKitap.Inf.DATA;

namespace EKitap.App.Services.YazarService
{
    public class YazarService : IYazarService
    {
        private readonly IYazarRepository _yazarRepository;
        private readonly IMapper _mapper;

        EKitapSatısDB context = new();

        public YazarService(IYazarRepository yazarRepository, IMapper mapper)
        {
            _yazarRepository = yazarRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<Yazar_DTO>> TumMarkalarAsync()
        {
            List<Yazar_DTO> yazarlarDTO = new List<Yazar_DTO>();
            var yazarlar = await _yazarRepository.TumunuListeleAsync();
            _mapper.Map(yazarlar, yazarlarDTO);
            return yazarlarDTO;
        }

        public async Task<List<Yazar_DTO>> YazarListele()
        {
            var result = (from yazar in context.Yazarlar
                          select new Yazar_DTO
                          {
                              YazarID = yazar.YazarID,
                              YazarAdi = yazar.YazarAdi,
                              EklenmeTarihi = yazar.EklenmeTarihi,
                              GuncellemeTarihi = yazar.GuncellemeTarihi,
                              SilmeTarihi = yazar.SilmeTarihi
                          }).ToList();

            return result;
        }
    }
}
