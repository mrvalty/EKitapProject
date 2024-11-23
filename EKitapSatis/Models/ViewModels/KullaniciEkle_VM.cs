using System.ComponentModel.DataAnnotations;

namespace EKitapSatis.Models.ViewModels
{
    public class KullaniciEkle_VM
    {
        [Required, MaxLength(20)]
        public string Ad { get; set; }
        [Required, MaxLength(20)]
        public string Soyad { get; set; }

        [Required, MinLength(7), MaxLength(20)]
        public string KullaniciAdi { get; set; }

        [Required, EmailAddress]
        public string EPosta { get; set; }

        [Required, DataType(DataType.Password), MinLength(7)]
        public string Sifre { get; set; }
        //[Required, DataType(DataType.Password), MinLength(7), Compare("Sifre")]
        //public string SifreTekrari { get; set; }
    }
}
