using EKitap.Dom.Abstract;
using EKitap.Dom.Repositories;
using EKitap.Inf.DATA;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace EKitap.Inf.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class, IEntity
    {
        protected EKitapSatısDB _context;
        protected DbSet<TEntity> _table;
        public BaseRepository(EKitapSatısDB context)
        {
            _context = context;
            _table = _context.Set<TEntity>();
        }

        public async Task<int> EkleAsync(TEntity entity)
        {
            var urun = await _table.AddAsync(entity);

            await _context.SaveChangesAsync();

            return (int)urun.Property(urun.Metadata.FindPrimaryKey().Properties.FirstOrDefault()).CurrentValue;
        }

        public async Task<IEnumerable<TResult>> FiltreleVeBirlestirAsync<TResult>(
            Expression<Func<TEntity, TResult>> select,
            Expression<Func<TEntity, bool>> where,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> include = null)
        {
            IQueryable<TEntity> query = _table.AsNoTracking();

            if (where != null)
                query = query.Where(where);
            if (include != null)
                query = include(query);
            if (orderBy != null)
                return await orderBy(query).Select(select).ToListAsync();
            else
                return await query.Select(select).ToListAsync();
        }

        public async Task GuncelleAsync(TEntity entity)
        {
            entity.GuncellemeTarihi = DateTime.Now;
            entity.KayitDurumu = Dom.Enums.KayitDurumu.Guncellendi;
            _table.Update(entity);
            _context.SaveChangesAsync();
        }

        public async Task<TEntity> IDyeGoreBulAsync(int id)
        {
            return await _table.FindAsync(id);
        }

        public async Task SilAsync(int id)
        {
            var entity = await _table.FindAsync(id);
            entity.SilmeTarihi = DateTime.Now;
            entity.KayitDurumu = Dom.Enums.KayitDurumu.Silindi;
            _table.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<TEntity>> TumunuListeleAsync(bool tumu = false)
        {
            //    if (!tumu)
            //        return await _table.Where(x => x.KayitDurumu != Dom.Enums.KayitDurumu.Silindi).ToListAsync();

            //    return await _table.ToListAsync();

            return null;
        }
    }
}
