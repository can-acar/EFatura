using System.Text.Json.Serialization;

namespace Models
{
    public class KullaniciBilgileri
    {
        [JsonPropertyName("vknTckn")]
        public string VknTckn { get; set; }

        [JsonPropertyName("unvan")]
        public string Unvan { get; set; }

        [JsonPropertyName("ad")]
        public string Ad { get; set; }

        [JsonPropertyName("soyad")]
        public string Soyad { get; set; }

        [JsonPropertyName("sicilNo")]
        public string SicilNo { get; set; }

        [JsonPropertyName("mersisNo")]
        public string MersisNo { get; set; }

        [JsonPropertyName("vergiDairesi")]
        public string VergiDairesi { get; set; }

        [JsonPropertyName("cadde")]
        public string Cadde { get; set; }

        [JsonPropertyName("apartmanAdi")]
        public string ApartmanAdi { get; set; }

        [JsonPropertyName("apartmanNo")]
        public string ApartmanNo { get; set; }

        [JsonPropertyName("kapiNo")]
        public string KapiNo { get; set; }

        [JsonPropertyName("kasaba")]
        public string Kasaba { get; set; }

        [JsonPropertyName("ilce")]
        public string Ilce { get; set; }

        [JsonPropertyName("il")]
        public string İl { get; set; }

        [JsonPropertyName("postaKodu")]
        public string PostaKodu { get; set; }

        [JsonPropertyName("ulke")]
        public string Ulke { get; set; }

        [JsonPropertyName("telNo")]
        public string TelNo { get; set; }

        [JsonPropertyName("faksNo")]
        public string FaksNo { get; set; }

        [JsonPropertyName("ePostaAdresi")]
        public string EPostaAdresi { get; set; }

        [JsonPropertyName("webSitesiAdresi")]
        public string WebSitesiAdresi { get; set; }

        [JsonPropertyName("isMerkezi")]
        public string IsMerkezi { get; set; }
    }
}