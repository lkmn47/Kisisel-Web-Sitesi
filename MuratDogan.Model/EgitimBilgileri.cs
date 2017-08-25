using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuratDogan.Model
{
    public class EgitimBilgileri
    {
        public int Id { get; set; }
        public string Kurum { get; set; }
        public string Pozisyon { get; set; }
        public string Icerik { get; set; }
        [DataType(DataType.Date)]
        public DateTime BaslamaTarihi { get; set; }
        public DateTime TamamlamaTarihi { get; set; }

    }
}
