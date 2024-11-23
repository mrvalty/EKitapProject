using AutoMapper;
using EKitap.App.Models.DTOs.Sepet;
using EKitap.App.Models.ViewModels;
using EKitap.Dom.Repositories;
using EKitap.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKitap.App.Services.SepetService
{
    public class SepetService : ISepetService
    {
        private readonly ISepetRepository _sepetRepository;
        private readonly IMapper _mapper;
        public SepetService(ISepetRepository sepetRepository, IMapper mapper)
        {
            _sepetRepository = sepetRepository;
            _mapper = mapper;
        }
        public async Task SepeteEkleAsync(Sepet_DTO kitap)
        {
            var sepettekiUrun = (await _sepetRepository.FiltreleVeBirlestirAsync(x => x, x => x.KitapID == kitap.KitapID && x.KullaniciID == kitap.KullaniciID)).SingleOrDefault();
            Sepet sepet = new Sepet();
            _mapper.Map(kitap, sepet);

            if (sepettekiUrun == null)
            {
                await _sepetRepository.EkleAsync(sepet);
            }
            else
            {
                sepettekiUrun.Adet += 1;
                await _sepetRepository.GuncelleAsync(sepettekiUrun);
            }
        }
        public async Task<IEnumerable<Sepet_VM>> SepettekiUrunler(int kullaniciID)
        {
            var sepettekiUrunler = await _sepetRepository.FiltreleVeBirlestirAsync(x => x, x => x.KullaniciID == kullaniciID, null, x => x.Include(y => y.Kitap));
            List<Sepet_VM> urunler = new List<Sepet_VM>();
            _mapper.Map(sepettekiUrunler, urunler);

            return urunler;
        }
    }
}
