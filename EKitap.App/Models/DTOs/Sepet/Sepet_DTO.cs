using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKitap.App.Models.DTOs.Sepet
{
    public class Sepet_DTO
    {
        public int? KitapID { get; set; }
        public int? KullaniciID { get; set; }
        public ushort Adet { get; set; }
    }
}
