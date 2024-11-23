using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKitap.App.Models.DTOs.Kitap
{
    public class Kitap_DTO
    {
        public int KitapID { get; set; }
        public string KitapAdi { get; set; }
        public string KitapResmi { get; set; }
        public decimal Fiyat { get; set; }
    }
}
