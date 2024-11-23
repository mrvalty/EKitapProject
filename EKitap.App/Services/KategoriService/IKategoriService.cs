using EKitap.App.Models.DTOs.Kategori;
using EKitap.Domain.Models;

namespace EKitap.App.Services.KategoriService
{
    public interface IKategoriService
    {
        Task<IEnumerable<Kategori_DTO>> TumKategorilerAsync();
        Task<List<Kategori>> GetAll();
    }
}
