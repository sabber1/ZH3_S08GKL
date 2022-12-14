using ZH3_forms.ReceptModels;

namespace ZH3_forms
{
    public class Hozzavalo
    {
        public int ReceptId { get; set; }
        public int? FogasId { get; set; }
        public string Név { get; set; }
        public double? Mennyiség4 { get; set; }
        public string? MennyisegiEgysegs { get; set; }
        public decimal? EgysÁr { get; set; }
    }
}