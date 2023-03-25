using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicLayer;

namespace HastaneSistemi.Sekreter
{
    public partial class SekreterEkle : Form
    {
        public SekreterEkle()
        {
            InitializeComponent();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            EntityLayer.EntitySekreter ent = new EntityLayer.EntitySekreter();
            ent.Ad1 = txt_ad.Text;
            ent.Soyad1 = txt_tc.Text;
            ent.Cinsiyet1 = comboBox1.Text;
            ent.TcNo1 = txt_tc.Text;
            ent.TelefonNo1 = txt_telefon.Text;
            ent.Sifre1 = txt_sifre.Text;
            int i = LogicLayer.LogicSekreter.LLSekreterEkle(ent);
            if (i == -1)
            {
                MessageBox.Show("Sekreter eklenemedi lütfen kontrol ediniz.");
            }
            else
            {
                MessageBox.Show("Sekreter Başarıyla eklenmiştir.");
                this.Close();
            }
        }

        private void SekreterEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
