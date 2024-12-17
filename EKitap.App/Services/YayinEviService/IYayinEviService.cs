using EKitap.App.Models.DTOs.YayinEvi;

namespace EKitap.App.Services.YayinEviService;
public interface IYayinEviService
{
    Task<List<YayinEvi_DTO>> YayinEviListele();
    Task YayinEviSil(int id);

}
