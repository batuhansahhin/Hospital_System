using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    class EntityRecete
    {
        private int ReceteNo;
        private string IlacAdi;
        private string IlacTuru;
        private string KullanimSekli;
        private DateTime ReceteTarihi;
        private int PaketSayisi;
        private int HastaNo;
        private int DoktorNo;

        public int ReceteNo1 { get => ReceteNo; set => ReceteNo = value; }
        public string IlacAdi1 { get => IlacAdi; set => IlacAdi = value; }
        public string IlacTuru1 { get => IlacTuru; set => IlacTuru = value; }
        public string KullanimSekli1 { get => KullanimSekli; set => KullanimSekli = value; }
        public DateTime ReceteTarihi1 { get => ReceteTarihi; set => ReceteTarihi = value; }
        public int PaketSayisi1 { get => PaketSayisi; set => PaketSayisi = value; }
        public int HastaNo1 { get => HastaNo; set => HastaNo = value; }
        public int DoktorNo1 { get => DoktorNo; set => DoktorNo = value; }
    }
}
