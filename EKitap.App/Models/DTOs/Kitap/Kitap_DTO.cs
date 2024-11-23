namespace EKitap.App.Models.DTOs.Kitap
{
    public class Kitap_DTO
    {
        public int KitapID { get; set; }
        public string KitapAdi { get; set; }
        public string Aciklama { get; set; }
        public string KitapResmi { get; set; }
        public decimal Fiyat { get; set; }
    }
}
