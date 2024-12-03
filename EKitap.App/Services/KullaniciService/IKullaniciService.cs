using EKitap.App.Models.DTOs.Kullanici;
using EKitap.Domain.Models;
using System.Security.Claims;

namespace EKitap.App.Services.KullaniciService
{
    public interface IKullaniciService
    {
        Task<bool> YeniKullaniciEkleAsync(KullaniciEkle_DTO kullanici);
        Task UyeSilAsync(int id);

        Task<Kullanici> KullaniciGirisAsync(KullaniciGiris_DTO login);

        Task<List<KullaniciListe_DTO>> KullaniciListesi();

        Task<int> KullaniciIDGetirAsync(ClaimsPrincipal claims);
    }
}
