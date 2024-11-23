using EKitap.Dom.Repositories;
using EKitap.Domain.Models;
using EKitap.Inf.DATA;

namespace EKitap.Inf.Repositories
{
    public class KategoriRepository : BaseRepository<Kategori>, IKategoriRepository
    {
        public KategoriRepository(EKitapSatısDB context) : base(context)
        {
        }

        public List<Kategori> GetAll()
        {
            var context = new EKitapSatısDB();

            var result = context.Kategoriler.ToList();

            return result;

        }
    }
}
