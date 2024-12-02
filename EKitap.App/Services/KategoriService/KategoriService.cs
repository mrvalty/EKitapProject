using AutoMapper;
using EKitap.App.Models.DTOs.Kategori;
using EKitap.Dom.Repositories;
using EKitap.Domain.Models;
using EKitap.Inf.DATA;

namespace EKitap.App.Services.KategoriService
{
    public class KategoriService : IKategoriService
    {
        private readonly IKategoriRepository _kategoriRepository;
        private readonly IMapper _mapper;
        EKitapSatısDB _context = new();

        public KategoriService(IKategoriRepository kategoriRepository, IMapper mapper)
        {
            _kategoriRepository = kategoriRepository;
            _mapper = mapper;
        }

        public async Task<List<Kategori>> GetAll()
        {
            var kategoriler = _kategoriRepository.GetAll();
            return kategoriler;
        }


        public async Task<IEnumerable<Kategori_DTO>> TumKategorilerAsync()
        {
            List<Kategori_DTO> kategorilerDTO = new List<Kategori_DTO>();
            var kategoriler = await _kategoriRepository.TumunuListeleAsync();
            _mapper.Map(kategoriler, kategorilerDTO);
            return kategorilerDTO;
        }

        public async Task<List<Kategori_DTO>> KategoriListele()
        {
            var result = (from kategori in _context.Kategoriler
                          select new Kategori_DTO
                          {
                              KategoriID = kategori.KategoriID,
                              KategoriAdi = kategori.KategoriAdi,
                              EklenmeTarihi = kategori.EklenmeTarihi,
                              GuncellemeTarihi = kategori.GuncellemeTarihi,
                              SilmeTarihi = kategori.SilmeTarihi,
                              KayitDurumu = kategori.KayitDurumu
                          }).ToList();

            return result;
        }

        public async Task KategoriSil(int id)
        {
            await _kategoriRepository.SilAsync(id);
        }
    }
}
