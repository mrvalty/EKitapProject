namespace EKitap.App.Models.DTOs.Yazar
{
    public class Yazar_DTO
    {
        public int YazarID { get; set; }
        public string YazarAdi { get; set; }
        public DateTime EklenmeTarihi { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
    }
}
