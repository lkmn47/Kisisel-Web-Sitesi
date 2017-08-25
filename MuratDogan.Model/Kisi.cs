using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuratDogan.Model
{
    public class Kisi
    {
        public int Id { get; set; }

        [Required]
        public string Ad { get; set; }
        public string SoyAd { get; set; }

        [Display(Name = "Doğum Yeri")]
        public string DogumYeri { get; set; }
        [Display(Name = "Doğum Tarihi")]

        public DateTime DogumTarihi { get; set; }
        public string MedeniDurumu { get; set; }
        public string AskerlikDurumu { get; set; }
        public string Ehliyet { get; set; }
        public string FotoUrl { get; set; }
        public virtual List<EgitimBilgileri> EgitimBilgileri { get; set; }
        public virtual List<IletisimBilgileri> IletisimBilgileri { get; set; }
        public virtual KariyerHedefi KariyerHedefi { get; set; }
        public virtual List<Projeler> Projeler { get; set; }
        public virtual List<Referanslar> Referanslar { get; set; }
        public virtual List<Sertifikalar> Sertifikalar { get; set; }
        public virtual List<Tecrube> Tecrubeler { get; set; }
        public virtual List<YabanciDil> YabanciDiller { get; set; }
        public virtual List<Yetenekler> Yetenekler { get; set; }
        public virtual CV CV { get; set; }

    }
}
