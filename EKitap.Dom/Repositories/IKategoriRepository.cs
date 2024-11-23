using EKitap.Domain.Models;

namespace EKitap.Dom.Repositories
{
    public interface IKategoriRepository : IBaseRepository<Kategori>
    {
        List<Kategori> GetAll();
    }
}
