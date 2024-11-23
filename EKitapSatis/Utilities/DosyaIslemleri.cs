namespace EKitapSatis.Utilities
{
    public class DosyaIslemleri
    {
        public static async Task<string> DosyaKaydetAsync(IFormFile dosya)
        {
            string strGuid = Guid.NewGuid().ToString() + dosya.FileName;
            string strDosyaYolu = "wwwroot/UrunResimleri/" + strGuid;

            FileStream file = new FileStream(strDosyaYolu, FileMode.Create);
            await dosya.CopyToAsync(file);
            file.Close();

            return strGuid;

        }
    }
}
