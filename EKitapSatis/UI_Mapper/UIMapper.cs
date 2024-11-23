using AutoMapper;
using EKitap.App.Models.DTOs.Kitap;
using EKitap.App.Models.DTOs.Kullanici;
using EKitapSatis.Models.ViewModels;

namespace EKitapSatis.UI_Mapper
{
    public class UIMapper : Profile
    {
        public UIMapper()
        {
            CreateMap<KullaniciEkle_VM, KullaniciEkle_DTO>().ReverseMap();
            CreateMap<KitapEkle_VM, KitapEkle_DTO>().ReverseMap();
        }
        
    }
}
