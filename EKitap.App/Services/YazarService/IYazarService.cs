using EKitap.App.Models.DTOs.Yazar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKitap.App.Services.YazarService
{
    public interface IYazarService
    {
        Task<IEnumerable<Yazar_DTO>> TumMarkalarAsync();
    }
}
