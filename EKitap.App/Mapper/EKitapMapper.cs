using AutoMapper;
using EKitap.App.Models.DTOs.Kategori;
using EKitap.App.Models.DTOs.Kitap;
using EKitap.App.Models.DTOs.Sepet;
using EKitap.App.Models.DTOs.Yazar;
using EKitap.App.Models.ViewModels;
using EKitap.Dom.Models;
using EKitap.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKitap.App.Mapper
{
    public class EKitapMapper : Profile
    {
        public EKitapMapper()
        {
            CreateMap<Kategori, Kategori_DTO>().ReverseMap();
            CreateMap<Yazar, Yazar_DTO>().ReverseMap();

            CreateMap<Kitap, Kitap_DTO>().ReverseMap();
            CreateMap<Kitap, KitapEkle_DTO>().ReverseMap();

            CreateMap<Sepet, Sepet_DTO>().ReverseMap();
            CreateMap<Sepet_VM, Sepet>().ReverseMap()
                                        .ForMember(x => x.KitapAdi, y => y.MapFrom(x => x.Kitap.KitapAdi))
                                        .ForMember(x => x.Fiyat, y => y.MapFrom(x => x.Kitap.Fiyat));
        }
    }
}
