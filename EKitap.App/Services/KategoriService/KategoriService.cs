using AutoMapper;
using EKitap.App.Models.DTOs.Kategori;
using EKitap.Dom.Enums;
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

        public KategoriService(IKategoriRepository kategoriRepository, IMapper mapper, EKitapSatısDB context)
        {
            _kategoriRepository = kategoriRepository;
            _mapper = mapper;
            _context = context;
        }

        public async Task<List<Kategori>> GetAll()
        {
            var result = _context.Kategoriler.ToList();

            //var kategoriler = _kategoriRepository.GetAll();
            return result;
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
                          }).OrderBy(x => x.KategoriAdi).ToList();

            return result;
        }

        public async Task KategoriSil(int id)
        {

            Kategori kategori = _context.Kategoriler.Where(x => x.KategoriID == id).First();
            if (kategori != null)
            {
                kategori.SilmeTarihi = DateTime.Now;
                kategori.KayitDurumu = KayitDurumu.Silindi;

                _context.SaveChanges();
            }
            //_kategoriRepository.SilAsync(id);
        }

        public async Task<List<KategoriIdListKitap_DTO>> KategoriyeGoreKitap(int id)
        {
            var result = (from kategori in _context.Kategoriler
                          join kitap in _context.Kitaplar on kategori.KategoriID equals kitap.KategoriID
                          where kategori.KategoriID == id
                          select new KategoriIdListKitap_DTO
                          {
                              KategoriID = kategori.KategoriID,
                              Aciklama = kitap.Aciklama,
                              Fiyat = kitap.Fiyat.ToString(),
                              KitapAdi = kitap.KitapAdi,
                              KitapID = kitap.KitapID,
                              YazarAdi = kitap.Yazar.YazarAdi,
                              ResimDosyasi = kitap.KitapResmi,
                              KategoriAdi = kategori.KategoriAdi
                          }).OrderByDescending(x => x.KitapAdi).ToList();

            return result;
        }
    }
}
