using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuratDogan.Model
{
    public class Tecrube
    {
        public int Id { get; set; }
        public string FirmaAdi { get; set; }
        public string Pozisyon { get; set; }
        public string Icerik { get; set; }
        public DateTime BaslamaTarihi { get; set; }
        public DateTime CikisTarihi { get; set; }
    }
}
