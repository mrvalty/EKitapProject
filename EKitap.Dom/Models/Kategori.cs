using EKitap.Dom.Abstract;
using EKitap.Dom.Enums;

namespace EKitap.Domain.Models
{
    public class Kategori : IEntity
    {
        public int KategoriID { get; set; }
        public string KategoriAdi { get; set; }
        public DateTime EklenmeTarihi { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public DateTime? SilmeTarihi { get; set; }
        public KayitDurumu KayitDurumu { get; set; }
        public ICollection<KitapYazar>? KitapYazarlar { get; set; }
        public ICollection<Kitap> Kitaplar { get; set; }
    }
}
