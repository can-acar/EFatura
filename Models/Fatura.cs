using System;
using System.Text.Json.Serialization;

namespace Models
{
    public class Fatura
    {
        [JsonPropertyName("faturaUuid")]
        public Guid Id { get; set; }

        [JsonPropertyName("belgeNumarasi")]
        public string BelgeNumarasi { get; set; }

        [JsonPropertyName("faturaTarihi")]
        public DateTime FaturaTarihi { get; set; }

        [JsonPropertyName("saat")]
        public TimeSpan Saat { get; set; }

        [JsonPropertyName("paraBirimi")]
        public string ParaBirimi { get; set; }

        [JsonPropertyName("dovzTlKur")]
        public string DovzTlKur { get; set; }

        [JsonPropertyName("faturaTipi")]
        public string FaturaTipi { get; set; }

        [JsonPropertyName("hangiTip")]
        public string HangiTip { get; set; } = "5000/30000";

        [JsonPropertyName("vknTckn")]
        public string VknTckn { get; set; } = "11111111111";

        [JsonPropertyName("aliciUnvan")]
        public string AliciUnvan { get; set; }

        [JsonPropertyName("aliciAdi")]
        public string AliciAdi { get; set; }

        [JsonPropertyName("aliciSoyadi")]
        public string AliciSoyadi { get; set; }

        [JsonPropertyName("binaAdi")]
        public string BinaAdi { get; set; }
    }
}