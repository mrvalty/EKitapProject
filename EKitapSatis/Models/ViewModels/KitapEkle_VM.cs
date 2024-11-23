namespace EKitapSatis.Models.ViewModels
{
    public class KitapEkle_VM
    {
        public string UrunAdi { get; set; }
        public IFormFile? UrunResmi { get; set; }
        public decimal Fiyat { get; set; }
        public int StokAdedi { get; set; }
        public string Aciklama { get; set; }


        public int YazarID { get; set; }

        public int[] KategoriIDleri { get; set; }
    }
}
