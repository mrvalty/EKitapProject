using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKitap.App.Models.ViewModels
{
    public class Sepet_VM
    {
        public int ID { get; set; } 
        public int? KitapID { get; set; }
        public int? KullaniciID { get; set; }
        public ushort Adet { get; set; }

        public string KitapAdi { get; set; } 
        public decimal Fiyat { get; set; }
    }
}
