using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKitap.Domain.Models
{
    public class Kullanici:IdentityUser<int>
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public ICollection<Kitap>? Kitaplar { get; set; }
        public ICollection<Sepet>? Sepet { get; set; }
    }
}
