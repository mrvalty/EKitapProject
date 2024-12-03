using EKitap.Dom.Models;
using Microsoft.AspNetCore.Identity;

namespace EKitap.Domain.Models
{
    public class Kullanici : IdentityUser<int>
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public ICollection<Kitap>? Kitaplar { get; set; }
        public ICollection<Sepet>? Sepet { get; set; }
        public ICollection<IletisimBilgisi>? IletisimBilgisi { get; set; }
    }
}
