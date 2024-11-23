using Microsoft.AspNetCore.Mvc.Rendering;

namespace EKitapSatis.Models.ViewModels
{
    public class KitapEklemeEkrani_VM
    {
        public KitapEkle_VM Urun { get; set; }
        public SelectList Kategoriler { get; set; }
        public SelectList Yazarlar { get; set; }
    }
}
