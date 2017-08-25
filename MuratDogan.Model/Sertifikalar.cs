using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuratDogan.Model
{
    public class Sertifikalar
    {
        public int Id { get; set; }
        public string SertifikaAdi { get; set; }
        public string KurumAdi { get; set; }
        public DateTime VerilisTarihi { get; set; }

    }
}
