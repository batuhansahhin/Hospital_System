using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//3 katmanada ihtiyacımız olucağı için
using EntityLayer;
using DataAccessLayer;
using LogicLayer;

namespace HastaneSistemi.Sekreter
{
    public partial class sekreterAnaSayfa : Form
    {
        public sekreterAnaSayfa()
        {
            InitializeComponent();
        }

        private void sekreterAnaSayfa_Load(object sender, EventArgs e)
        {

        }

        private void btn_DoktorEkle_Click(object sender, EventArgs e)
        {
            DoktorEkle doktorEkle = new DoktorEkle();
            doktorEkle.ShowDialog();
        }

        private void btn_Doktorsil_guncelle_Click(object sender, EventArgs e)
        {
            DoktorGuncelleSil doktorGuncelleSil = new DoktorGuncelleSil();
            doktorGuncelleSil.ShowDialog();
        }

        private void btn_SekreterEkle_Click(object sender, EventArgs e)
        {
            SekreterEkle sekreterEkle = new SekreterEkle();
            sekreterEkle.ShowDialog();
        }

        private void btn_SekreterSilGuncelle_Click(object sender, EventArgs e)
        {
            SekreterGuncelleSil sekreterGuncelleSil = new SekreterGuncelleSil();
            sekreterGuncelleSil.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HastaEkle hastaEkle = new HastaEkle();
            hastaEkle.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HastaGuncelleSil hastaGuncelleSil = new HastaGuncelleSil();
            hastaGuncelleSil.ShowDialog();
        }
    }
}
