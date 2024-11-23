using EKitap.Dom.Abstract;
using EKitap.Dom.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace EKitap.Domain.Models
{
    public class Sepet:IEntity
    {
        public int ID { get; set; } 
        public int? KitapID { get; set; }
        public int? KullaniciID { get; set; }
        public ushort Adet { get; set; }

        public DateTime EklenmeTarihi { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public DateTime? SilmeTarihi { get; set; }
        public KayitDurumu KayitDurumu { get; set; }

        public Kitap? Kitap { get; set; }
        public Kullanici? Kullanici { get; set; }
    }
}
