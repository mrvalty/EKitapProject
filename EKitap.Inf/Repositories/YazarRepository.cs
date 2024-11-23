using EKitap.Dom.Models;
using EKitap.Dom.Repositories;
using EKitap.Inf.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKitap.Inf.Repositories
{
    public class YazarRepository : BaseRepository<Yazar>, IYazarRepository
    {
        public YazarRepository(EKitapSatısDB context) : base(context)
        {
        }
    }
}
