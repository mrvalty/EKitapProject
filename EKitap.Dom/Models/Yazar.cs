using EKitap.Dom.Abstract;
using EKitap.Dom.Enums;
using EKitap.Domain.Models;

namespace EKitap.Dom.Models
{
    public class Yazar : IEntity
    {
        public int YazarID { get; set; }
        public string YazarAdi { get; set; }

        public DateTime EklenmeTarihi { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public DateTime? SilmeTarihi { get; set; }
        public KayitDurumu KayitDurumu { get; set; }

        public ICollection<Kitap>? Kitaplar { get; set; }
    }
}

