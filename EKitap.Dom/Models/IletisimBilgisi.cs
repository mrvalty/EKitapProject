using EKitap.Dom.Abstract;
using EKitap.Dom.Enums;
using EKitap.Domain.Models;
using System.ComponentModel.DataAnnotations;

namespace EKitap.Dom.Models;
public class IletisimBilgisi : IEntity
{
    [Key]
    public int IletisimBilgiID { get; set; }
    public int KullaniciID { get; set; }
    public string AdresBasligi { get; set; }
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public string Il { get; set; }
    public string Ilce { get; set; }
    public string Mahalle { get; set; }
    public string Adres { get; set; }
    public string PostaKodu { get; set; }
    public string TelefonNo { get; set; }

    public virtual Kullanici Kullanici { get; set; }
    public DateTime EklenmeTarihi { get; set; }
    public DateTime? GuncellemeTarihi { get; set; }
    public DateTime? SilmeTarihi { get; set; }
    public KayitDurumu KayitDurumu { get; set; }
}
