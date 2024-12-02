using EKitap.Dom.Enums;

namespace EKitap.App.Models.DTOs.Kategori
{
    public class Kategori_DTO
    {
        public int KategoriID { get; set; }
        public string KategoriAdi { get; set; }
        public KayitDurumu KayitDurumu { get; set; }
        public DateTime? EklenmeTarihi { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public DateTime? SilmeTarihi { get; set; }
    }
}
