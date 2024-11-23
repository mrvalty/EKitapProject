﻿using EKitap.Dom.Repositories;
using EKitap.Domain.Models;
using EKitap.Inf.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKitap.Inf.Repositories
{
    public class SepetRepository : BaseRepository<Sepet>, ISepetRepository
    {
        public SepetRepository(EKitapSatısDB context) : base(context)
        {
        }
    }
}
