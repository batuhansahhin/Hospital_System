using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using LogicLayer;
namespace HastaneSistemi.Sekreter
{
    public partial class Grafikler : Form
    {
        public Grafikler()
        {
            InitializeComponent();
        }

        private void Grafikler_Load(object sender, EventArgs e)
        {
            chartPoliklinik.Series["poliklinik"].Points.AddXY("Kardiyoloji", LogicHasta.LLPolikliniklereGoreHastaSayisi("Kardiyoloji"));
            chartPoliklinik.Series["poliklinik"].Points.AddXY("Kadın Doğum", LogicHasta.LLPolikliniklereGoreHastaSayisi("Kadın Doğum"));
            chartPoliklinik.Series["poliklinik"].Points.AddXY("Genel Cerrahi", LogicHasta.LLPolikliniklereGoreHastaSayisi("Genel Cerrahi"));
            chartPoliklinik.Series["poliklinik"].Points.AddXY("Psikiyatri", LogicHasta.LLPolikliniklereGoreHastaSayisi("Psikiyatri"));
            chartPoliklinik.Series["poliklinik"].Points.AddXY("Üroloji", LogicHasta.LLPolikliniklereGoreHastaSayisi("Üroloji"));
            chartPoliklinik.Series["poliklinik"].Points.AddXY("Dahiliye", LogicHasta.LLPolikliniklereGoreHastaSayisi("Dahiliye"));


            List<string> doktorListesi = LogicDoktor.DoktorListesiGrafik();

            foreach(var doktorListe in doktorListesi)
            {
                chartDoktor.Series["doktor"].Points.AddXY(doktorListe, LogicHasta.LLDoktoraGoreHastaSayisi(doktorListe));
            }
            
            
        }
    }
}
