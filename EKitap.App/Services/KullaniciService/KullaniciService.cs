using EKitap.App.Models.DTOs.Kullanici;
using EKitap.Domain.Models;
using EKitap.Inf.DATA;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace EKitap.App.Services.KullaniciService
{
    public class KullaniciService : IKullaniciService
    {
        private readonly UserManager<Kullanici> _userManager;
        EKitapSatısDB _context = new();


        public KullaniciService(UserManager<Kullanici> userManager, EKitapSatısDB context)
        {
            _userManager = userManager;
            _context = context;
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

        public async Task<List<KullaniciListe_DTO>> KullaniciListesi()
        {
            var result = (from iletisim in _context.IletisimBilgileri
                          join kullanici in _context.Users on iletisim.KullaniciID equals kullanici.Id
                          select new KullaniciListe_DTO()
                          {
                              AdSoyad = kullanici.Ad + " " + kullanici.Soyad,
                              KullaniciAdi = kullanici.UserName,
                              Eposta = kullanici.Email,
                              Telefon = iletisim.TelefonNo,
                              Il = iletisim.Il,
                              Ilce = iletisim.Ilce,
                              Adres = iletisim.Adres,
                              KullaniciID = kullanici.Id,
                              IletisimID = iletisim.IletisimBilgiID
                          }).OrderBy(x => x.KullaniciAdi).ToList();

            return result;
        }
    }
}
