using EKitap.App.Models.DTOs.Sepet;
using EKitap.App.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKitap.App.Services.SepetService
{
    public interface ISepetService
    {
        Task SepeteEkleAsync(Sepet_DTO urun);
        Task<IEnumerable<Sepet_VM>> SepettekiUrunler(int kullaniciID);
    }
}
