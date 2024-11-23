using EKitap.Dom.Repositories;
using EKitap.Domain.Models;
using EKitap.Inf.DATA;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKitap.Inf.Repositories
{
    public class KitapRepository : BaseRepository<Kitap>, IKitapRepository
    {
        public KitapRepository(EKitapSatısDB context) : base(context)
        {
        }

        public async Task<Kitap> GetByIdAsync(int id)
        {
            return await _context.Kitaplar.FirstOrDefaultAsync(u => u.KitapID == id);
        }
    }
}

