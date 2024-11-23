using EKitap.App.Models.DTOs.Kitap;
using EKitap.App.Models.ViewModels;

namespace EKitap.App.Services.KitapService
{
    public interface IKitapService
    {
        Task<IEnumerable<Kitap_DTO>> TumUrunlerAsync();
        Task UrunEkleAsync(KitapEkle_DTO kitap);
        Task<KitapDetay_VM> UrunDetayGetirAsync(int id);
    }
}
