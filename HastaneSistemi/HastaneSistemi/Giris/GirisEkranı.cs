using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;
using EntityLayer;
using LogicLayer;

namespace HastaneSistemi.Giris
{
    public partial class GirisEkranı : Form
    {
        public GirisEkranı()
        {
            InitializeComponent();
        }

        private void SekreterGiris_Click(object sender, EventArgs e)
        {
            //Form2 form2 = new Form2();
            Sekreter.sekreterAnaSayfa  sekreterAnasayfa = new Sekreter.sekreterAnaSayfa();

            sekreterAnasayfa.Show();  // form2 göster diyoruz
            this.Hide();   // bu yani form1 gizle diyoruz

        }

        private void GirisEkranı_Load(object sender, EventArgs e)
        {

        }

        private void DoktorGiris_Click(object sender, EventArgs e)
        {
            Doktor.DoktorPaneli doktorPaneli = new Doktor.DoktorPaneli();

            doktorPaneli.Show();  // form2 göster diyoruz
            this.Hide();   // bu yani form1 gizle diyoruz

        }
    }
}
