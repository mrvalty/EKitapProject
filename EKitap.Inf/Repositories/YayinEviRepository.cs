using EKitap.Dom.Models;
using EKitap.Dom.Repositories;
using EKitap.Inf.DATA;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EKitap.Inf.Repositories
{
    public class YayinEviRepository : BaseRepository<YayinEvi>, IYayinEviRepository
    {
        public YayinEviRepository(EKitapSatısDB context) : base(context)
        {

        }
        
    }
}
