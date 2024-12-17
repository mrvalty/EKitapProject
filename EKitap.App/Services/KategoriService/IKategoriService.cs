using EKitap.App.Models.DTOs.Kategori;
using EKitap.Domain.Models;

namespace EKitap.App.Services.KategoriService
{
    public interface IKategoriService
    {
        Task<IEnumerable<Kategori_DTO>> TumKategorilerAsync();
        Task<List<Kategori>> GetAll();
        Task<List<Kategori_DTO>> KategoriListele();

        Task KategoriSil(int id);

        Task<List<KategoriIdListKitap_DTO>> KategoriyeGoreKitap(int id);
    }
}
