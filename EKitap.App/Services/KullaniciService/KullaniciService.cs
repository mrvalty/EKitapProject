using EKitap.App.Models.DTOs.Kullanici;
using EKitap.Domain.Models;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace EKitap.App.Services.KullaniciService
{
    public class KullaniciService : IKullaniciService
    {
        private readonly UserManager<Kullanici> _userManager;

        public KullaniciService(UserManager<Kullanici> userManager)
        {
            _userManager = userManager;
        }

        public async Task<Kullanici> KullaniciGirisAsync(KullaniciGiris_DTO login)
        {
            var uye = await _userManager.FindByNameAsync(login.KullaniciAdiVeyaEPosta);
            if (uye == null)
            {
                uye = await _userManager.FindByEmailAsync(login.KullaniciAdiVeyaEPosta);
                if (uye == null)
                    return uye;
            }

            if (!await _userManager.CheckPasswordAsync(uye, login.Sifre))
                return uye;

            return uye;

        }

        public async Task<int> KullaniciIDGetirAsync(ClaimsPrincipal claims)
        {
            return int.Parse(await _userManager.GetUserIdAsync(await _userManager.GetUserAsync(claims)));
        }

        public Task UyeSilAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> YeniKullaniciEkleAsync(KullaniciEkle_DTO kullanici)
        {
            Kullanici yeniUye = new Kullanici()
            {
                Ad = kullanici.Ad,
                Soyad = kullanici.Soyad,
                UserName = kullanici.KullaniciAdi,
                Email = kullanici.EPosta
            };
            var result = await _userManager.CreateAsync(yeniUye, kullanici.Sifre);
            await _userManager.AddToRoleAsync(yeniUye, "Kullanici");

            return result.Succeeded;
        }
    }
}
