using Microsoft.AspNetCore.Http;

namespace EKitap.App.Services.Extensions;
public class FileExtensions
{
    public static async Task<string> DosyaKaydetAsync(IFormFile dosya)
    {
        string strGuid = Guid.NewGuid().ToString() + dosya.FileName;
        string strDosyaYolu = "wwwroot/KitapResimleri/" + strGuid;

        FileStream file = new FileStream(strDosyaYolu, FileMode.Create);
        await dosya.CopyToAsync(file);
        file.Close();

        return strGuid;

    }
}
