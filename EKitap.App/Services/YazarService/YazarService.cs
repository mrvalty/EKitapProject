using AutoMapper;
using EKitap.App.Models.DTOs.Yazar;
using EKitap.Dom.Enums;
using EKitap.Dom.Models;
using EKitap.Dom.Repositories;
using EKitap.Inf.DATA;

namespace EKitap.App.Services.YazarService
{
    public class YazarService : IYazarService
    {
        private readonly IYazarRepository _yazarRepository;
        private readonly IMapper _mapper;

        EKitapSatısDB _context = new();

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
            var result = (from yazar in _context.Yazarlar
                          select new Yazar_DTO
                          {
                              YazarID = yazar.YazarID,
                              YazarAdi = yazar.YazarAdi,
                              EklenmeTarihi = yazar.EklenmeTarihi,
                              KayitDurumu = yazar.KayitDurumu,
                              SilmeTarihi = yazar.SilmeTarihi
                          }).ToList();
            return result;
        }
        public async Task YazarSil(int id)
        {

            Yazar yazar = _context.Yazarlar.Where(x => x.YazarID == id).First();
            if (yazar != null)
            {
                yazar.SilmeTarihi = DateTime.Now;
                yazar.KayitDurumu = KayitDurumu.Silindi;

                _context.SaveChanges();
            }
            //_kategoriRepository.SilAsync(id);
        }
    }
}
