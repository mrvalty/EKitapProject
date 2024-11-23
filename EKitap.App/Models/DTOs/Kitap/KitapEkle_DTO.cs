using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKitap.App.Models.DTOs.Kitap
{
    public class KitapEkle_DTO
    {
        public string KitapAdi { get; set; }
        public string KitapResmi { get; set; }
        public decimal Fiyat { get; set; }
        public int StokAdedi { get; set; }
        public string Aciklama { get; set; }
        public int YazarID { get; set; }
        public int KullaniciID { get; set; }

        public int[] KategoriIDleri { get; set; }
    }
}
