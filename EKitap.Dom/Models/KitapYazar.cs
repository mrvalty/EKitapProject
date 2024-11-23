using EKitap.Dom.Abstract;
using EKitap.Dom.Enums;
using EKitap.Dom.Models;

namespace EKitap.Domain.Models
{
    public class KitapYazar : IEntity
    {
        public int ID { get; set; }
        public int KitapID { get; set; }
        public int YazarID { get; set; }

        public DateTime EklenmeTarihi { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public DateTime? SilmeTarihi { get; set; }
        public KayitDurumu KayitDurumu { get; set; }


        public Kitap? Kitap { get; set; }
        public Yazar? Yazar { get; set; }
        public IEnumerable<string> Kategoriler { get; set; }
    }
}
