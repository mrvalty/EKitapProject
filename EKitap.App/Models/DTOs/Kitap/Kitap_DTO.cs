using EKitap.App.Models.DTOs.Yazar;

namespace EKitap.App.Models.DTOs.Kitap
{
    public class Kitap_DTO
    {
        public int KitapID { get; set; }
        public string KitapAdi { get; set; }
        public string Aciklama { get; set; }
        public string KitapResmi { get; set; }
        public string YazarAdi { get; set; }
        public string YayinEvi { get; set; }
        public decimal Fiyat { get; set; }

        public List<Yazar_DTO> YazarListesi { get; set; }
    }
}
