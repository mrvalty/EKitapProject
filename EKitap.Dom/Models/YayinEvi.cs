using EKitap.Domain.Models;

namespace EKitap.Dom.Models;
public class YayinEvi
{
    public int YayinEviID { get; set; }
    public string YayinEviAd { get; set; }
    public string YetkiliKisi { get; set; }
    public string YayinEviAdres { get; set; }
    public string YayinEviMail { get; set; }
    public ICollection<Kitap>? Kitaplar { get; set; }
}
