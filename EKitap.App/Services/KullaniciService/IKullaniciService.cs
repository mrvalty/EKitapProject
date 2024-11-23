using EKitap.App.Models.DTOs.Kullanici;
using EKitap.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace EKitap.App.Services.KullaniciService
{
    public interface IKullaniciService
    {
        Task<bool> YeniKullaniciEkleAsync(KullaniciEkle_DTO kullanici);
        Task UyeSilAsync(int id);

        Task<Kullanici> KullaniciGirisAsync(KullaniciGiris_DTO login);

        Task<int> KullaniciIDGetirAsync(ClaimsPrincipal claims);
    }
}
