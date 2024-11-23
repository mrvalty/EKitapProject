namespace EKitapSatis.Models.ViewModels
{
    public class KitapEkle_VM
    {
        public string KitapAdi { get; set; }
        public IFormFile? KitapResmi { get; set; }
        public decimal Fiyat { get; set; }
        public int StokAdedi { get; set; }
        public string Aciklama { get; set; }

        public int YazarID { get; set; }
        public int YayinEviID { get; set; }
        public int KategoriID { get; set; }
    }
}
