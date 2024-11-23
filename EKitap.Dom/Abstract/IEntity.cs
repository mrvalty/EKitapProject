using EKitap.Dom.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKitap.Dom.Abstract
{
    public interface IEntity
    {
        public DateTime EklenmeTarihi { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public DateTime? SilmeTarihi { get; set; }

        public KayitDurumu KayitDurumu { get; set; }
    }
}
