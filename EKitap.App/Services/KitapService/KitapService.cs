﻿using AutoMapper;
using EKitap.App.Models.DTOs.Kitap;
using EKitap.App.Models.ViewModels;
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

            throw new NotImplementedException();
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
                              KitapResmi = kitap.KitapResmi
                          }).ToList();
            return result;
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
