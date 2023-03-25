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

namespace HastaneSistemi.Sekreter
{
    public partial class HastaEkle : Form
    {
        public HastaEkle()
        {
            InitializeComponent();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            EntityHasta ent = new EntityHasta();
            ent.Ad1 = txt_ad.Text;
            ent.Soyad1 = txt_tc.Text;
            ent.Cinsiyet1 = comboBox1.Text;
            ent.TcNo1 = txt_tc.Text;
            ent.TelefonNo1 = txt_telefon.Text;
            ent.GidilenBolum1 = comboBox2.Text;
            ent.SecilenDoktor1 =comboBox3.Text;
            ent.MailAdresi1 = txt_mail.Text;
            ent.RandevuTarihi1 = dateTimePicker1.Text;

            int i = LogicLayer.LogicHasta.LLHastaEkle(ent);
            if (i == -1)
            {
                MessageBox.Show("Hasta eklenemedi lütfen kontrol ediniz.");
            }
            else
            {
                MessageBox.Show("Hasta Başarıyla eklenmiştir.");
                this.Close();
            }
        }

        private void HastaEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
