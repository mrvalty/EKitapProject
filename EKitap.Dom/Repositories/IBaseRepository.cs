using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace EKitap.Dom.Repositories
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        Task<int> EkleAsync(TEntity entity);
        Task GuncelleAsync(TEntity entity);
        Task SilAsync(int id);

        Task<TEntity> IDyeGoreBulAsync(int id);
        Task<IEnumerable<TEntity>> TumunuListeleAsync(bool tumu = false);


        //Daha sonra eklenecekler...

        Task<IEnumerable<TResult>> FiltreleVeBirlestirAsync<TResult>(
            Expression<Func<TEntity, TResult>> select,
            Expression<Func<TEntity, bool>> where,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> include = null
            );
    }
}
