using EKitap.App.Models.DTOs.Yazar;

namespace EKitap.App.Services.YazarService
{
    public interface IYazarService
    {
        Task<IEnumerable<Yazar_DTO>> TumMarkalarAsync();
        Task<List<Yazar_DTO>> YazarListele();

        Task YazarSil(int id);
    }
}
