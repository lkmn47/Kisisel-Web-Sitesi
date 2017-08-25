using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuratDogan.Model
{
    public class IletisimBilgileri
    {
        public int ID { get; set; }
        public string EMail { get; set; }
        public string Adress { get; set; }
        public string Telelfon { get; set; }
        public List<string> SosyalAg { get; set; }
    }
}
