namespace EKitap.App.Models.DTOs.YayinEvi;
public class YayinEvi_DTO
{
    public int YayinEviID { get; set; }
    public string YayinEviAdi { get; set; }
    public DateTime EklenmeTarihi { get; set; }
    public DateTime? GuncellemeTarihi { get; set; }
    public DateTime? SilmeTarihi { get; set; }
}
