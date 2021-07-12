using System;
using System.Collections.Generic;
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

        [JsonPropertyName("binaNo")]
        public string BinaNo { get; set; }

        [JsonPropertyName("kapiNo")]
        public string KapiNo { get; set; }

        [JsonPropertyName("kasabaKoy")]
        public string KasabaKoy { get; set; }

        [JsonPropertyName("vergiDairesi")]
        public string VergiDairesi { get; set; }

        [JsonPropertyName("ulke")]
        public string Ulke { get; set; }

        [JsonPropertyName("bulvarcaddesokak")]
        public string BulvarCaddeSokak { get; set; }

        [JsonPropertyName("mahalleSemtIlce")]
        public string MahalleSemtIlce { get; set; }

        [JsonPropertyName("sehir")]
        public string Sehir { get; set; }

        [JsonPropertyName("postaKodu")]
        public int PostaKodu { get; set; }

        [JsonPropertyName("tel")]
        public string Tel { get; set; }

        [JsonPropertyName("fax")]
        public string Fax { get; set; }

        [JsonPropertyName("eposta")]
        public string Eposta { get; set; }


        [JsonPropertyName("websitesi")]
        public string WebSite { get; set; }

        [JsonPropertyName("iadeTable")]
        public IList<IadeTable> Iade { get; set; } = new List<IadeTable>();

        [JsonPropertyName("ozelMatrahTutari")]
        public decimal OzelMatrahTutari { get; set; } = 0;

        [JsonPropertyName("ozelMatrahOrani")]
        public decimal OzelMatrahOrani { get; set; } = 0;

        [JsonPropertyName("ozelMatrahVergiTutari")]
        public decimal OzelMatrahVergiTutari { get; set; } = 0;

        [JsonPropertyName("VergiCesidi")]
        public string VergiCesidi { get; set; }

        [JsonPropertyName("malHizmetTable")]
        public IList<MalHizmetTable> MalHizmet { get; set; } = new List<MalHizmetTable>();

        [JsonPropertyName("tip")]
        public string Tip { get; set; }

        [JsonPropertyName("matrah")]
        public decimal Matrah { get; set; }

        [JsonPropertyName("malhizmetToplamTutari")]
        public decimal MalHizmetToplamTutari { get; set; }

        [JsonPropertyName("toplamIskonto")]
        public decimal ToplamIskonto { get; set; }

        [JsonPropertyName("hesaplanankdv")]

        public decimal Hesaplanankdv { get; set; }

        [JsonPropertyName("vergilerToplami")]

        public decimal VergilerToplami { get; set; }

        [JsonPropertyName("vergilerDahilToplamTutar")]

        public decimal VergilerDahilToplamTutar { get; set; }

        [JsonPropertyName("not")]

        public string Not { get; set; }

        [JsonPropertyName("siparisNumarasi")]
        public string SiparisNumarasi { get; set; }

        [JsonPropertyName("siparisTarihi")]
        public string SiparisTarihi { get; set; }

        [JsonPropertyName("irsaliyeNumarasi")]
        public string İrsaliyeNumarasi { get; set; }

        [JsonPropertyName("irsaliyeTarihi")]
        public string İrsaliyeTarihi { get; set; }

        [JsonPropertyName("fisNo")]
        public string FisNo { get; set; }

        [JsonPropertyName("fisTarihi")]
        public string FisTarihi { get; set; }

        [JsonPropertyName("fisSaati")]
        public string FisSaati { get; set; }

        [JsonPropertyName("fisTipi")]
        public string FisTipi { get; set; }

        [JsonPropertyName("zRaporNo")]
        public string ZRaporNo { get; set; }

       [JsonPropertyName("okcSeriNo")]
        public string OkcSeriNo { get; set; }
    }
}