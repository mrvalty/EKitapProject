namespace EKitap.App.Models.ViewModels
{
    public class KitapDetay_VM
    {
        public int KitapID { get; set; }
        public string KitapAdi { get; set; }
        public string KitapResmi { get; set; }
        public decimal Fiyat { get; set; }
        public int StokAdedi { get; set; }
        public string Aciklama { get; set; }
        public string YazarAdi { get; set; }
        public int YazarID { get; set; }
        public string KategoriAdi { get; set; }
        public int KategoriID { get; set; }
        public string YayinEviAdi { get; set; }
        public List<string> Kategoriler { get; set; }
    }
}
