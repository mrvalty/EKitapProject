using AutoMapper;
using EKitap.App.Models.DTOs.Kitap;
using EKitap.App.Models.ViewModels;
using EKitap.App.Services.Extensions;
using EKitap.Dom.Enums;
using EKitap.Dom.Repositories;
using EKitap.Domain.Models;
using EKitap.Inf.DATA;

namespace EKitap.App.Services.KitapService
{
    public class KitapService : IKitapService
    {
        private readonly IKitapRepository _kitapRepository;
        private readonly IKitapYazarRepository _kitapYazarRepository;
        private readonly IMapper _mapper;

        EKitapSatısDB _context = new();

        public KitapService(IKitapRepository kitapRepository, IKitapYazarRepository kitapYazarRepository, IMapper mapper, EKitapSatısDB context)
        {
            _kitapRepository = kitapRepository;
            _kitapYazarRepository = kitapYazarRepository;
            _mapper = mapper;
        }

        public async Task KitapGuncelle(KitapEkle_DTO kitap)
        {
            var kitapInfo = _context.Kitaplar.Where(x => x.KitapID == kitap.KitapID).FirstOrDefault();
            if (kitapInfo != null)
            {
                kitapInfo.KitapAdi = kitap.KitapAdi;
                kitapInfo.Aciklama = kitap.Aciklama;
                kitapInfo.Fiyat = kitap.Fiyat;
                kitapInfo.StokAdedi = kitap.StokAdedi;
                if (kitap.KitapResmiFile != null) { kitapInfo.KitapResmi = FileExtensions.DosyaKaydetAsync(kitap.KitapResmiFile); }
                kitapInfo.GuncellemeTarihi = DateTime.Now;
                kitapInfo.KayitDurumu = Dom.Enums.KayitDurumu.Guncellendi;
            }
            _mapper.Map(kitapInfo, kitap);
            await _kitapRepository.GuncelleAsync(kitapInfo);
        }

        public async Task<List<Kitap_DTO>> KitapListesi()
        {
            var result = (from kitap in _context.Kitaplar
                          select new Kitap_DTO
                          {
                              KitapID = kitap.KitapID,
                              KitapAdi = kitap.KitapAdi,
                              Aciklama = kitap.Aciklama,
                              Fiyat = kitap.Fiyat,
                              YazarAdi = kitap.Yazar.YazarAdi,
                              YayinEvi = kitap.YayinEvi.YayinEviAd,
                              KitapResmi = kitap.KitapResmi,
                              EklenmeTarihi = kitap.EklenmeTarihi,
                              GuncellemeTarihi = kitap.GuncellemeTarihi,
                              SilmeTarihi = kitap.SilmeTarihi,
                              KayitDurumu = kitap.KayitDurumu,
                          }).ToList();
            return result;
        }

        public async Task KitapSil(int id)
        {

            Kitap kitap = _context.Kitaplar.Where(x => x.KitapID == id).First();
            if (kitap != null)
            {
                kitap.SilmeTarihi = DateTime.Now;
                kitap.KayitDurumu = KayitDurumu.Silindi;

                _context.SaveChanges();
            }

            //await _kitapRepository.SilAsync(id);
        }

        public async Task<IEnumerable<Kitap_DTO>> TumUrunlerAsync()
        {
            List<Kitap_DTO> kitaplatDTO = new List<Kitap_DTO>();
            var kitaplar = await _kitapYazarRepository.TumunuListeleAsync();
            _mapper.Map(kitaplar, kitaplatDTO);

            return kitaplatDTO;
        }

        public async Task<KitapDetay_VM> UrunDetayGetirAsync(int id)
        {
            var result = await _kitapRepository.FiltreleVeBirlestirAsync(x => new KitapDetay_VM
            {
                KitapID = x.KitapID,
                KitapAdi = x.KitapAdi,
                Fiyat = x.Fiyat,
                Aciklama = x.Aciklama,
                StokAdedi = x.StokAdedi,
                KitapResmi = x.KitapResmi,
                YazarID = x.Yazar.YazarID,
                YazarAdi = x.Yazar.YazarAdi,
                KategoriID = x.Kategori.KategoriID,
                YayinEviAdi = x.YayinEvi.YayinEviAd,
                //Kategoriler = x.Kategoriler.Select(x=>x.KategoriAdi).ToList()
            },
                x => x.KitapID == id,
                null, null
                //x => x.Include(y => y.Yazar).Include(y => y.Kategori).ThenInclude(y => y.KategoriAdi)
                );

            KitapDetay_VM urunDetay = result.SingleOrDefault();
            return urunDetay;
        }

        public async Task UrunEkleAsync(KitapEkle_DTO kitap)
        {
            Kitap yeniUrun = new Kitap();
            _mapper.Map(kitap, yeniUrun);

            int kitapID = await _kitapRepository.EkleAsync(yeniUrun);


            //await _kitapRepository.EkleAsync(new Kitap { KitapID = kitapID, KategoriID = kitap.KategoriID });
        }
    }
}
