using EKitap.Dom.Abstract;
using EKitap.Dom.Enums;
using EKitap.Dom.Models;

namespace EKitap.Domain.Models
{
    public class Kitap : IEntity
    {
        public int KitapID { get; set; }
        public string KitapAdi { get; set; }
        public string KitapResmi { get; set; }
        public decimal Fiyat { get; set; }
        public int StokAdedi { get; set; }
        public string Aciklama { get; set; }

        public DateTime EklenmeTarihi { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public DateTime? SilmeTarihi { get; set; }
        public KayitDurumu KayitDurumu { get; set; }

        public int KullaniciID { get; set; }
        public int KategoriID { get; set; }
        public int YazarID { get; set; }
        public int YayinEviID { get; set; }


        public ICollection<KitapYazar>? KitapYazar { get; set; }
        //public ICollection<Kategori> Kategoriler { get; set; }
        public virtual Kategori? Kategori { get; set; }
        public Kullanici? Kullanici { get; set; }
        public Yazar? Yazar { get; set; }
        public YayinEvi? YayinEvi { get; set; }

        public ICollection<Sepet>? Sepet { get; set; }
    }
}
