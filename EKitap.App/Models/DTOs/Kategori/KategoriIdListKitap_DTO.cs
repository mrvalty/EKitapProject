using System.Text.Json.Serialization;

namespace EKitap.App.Models.DTOs.Kategori;
public class KategoriIdListKitap_DTO
{
    [JsonPropertyName("KategoriID")]
    public int KategoriID { get; set; }

    [JsonPropertyName("KitapID")]
    public int KitapID { get; set; }

    [JsonPropertyName("KitapAdi")]
    public string KitapAdi { get; set; }

    [JsonPropertyName("YazarAdi")]
    public string YazarAdi { get; set; }

    [JsonPropertyName("Fiyat")]
    public string Fiyat { get; set; }

    [JsonPropertyName("Aciklama")]
    public string Aciklama { get; set; }

    [JsonPropertyName("KategoriAdi")]
    public string KategoriAdi { get; set; }

    [JsonPropertyName("ResimDosyasi")]
    public string ResimDosyasi { get; set; }
}
