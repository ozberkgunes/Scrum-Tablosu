using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scrumTableProje
{
    public class HikayeDetay
    {
        public string aciklama { get; set; }
        public string isim { get; set; }
        public string baslik { get; set; }
        public DateTime tarih { get; set; }
        public List<TaskDetay> taskListe { get; set; }

    }
}
