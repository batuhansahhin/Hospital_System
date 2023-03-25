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
    public partial class DoktorEkle : Form
    {
        public DoktorEkle()
        {
            InitializeComponent();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            
            EntityDoktor ent = new EntityDoktor();
            ent.Ad1 = txt_ad.Text;
            ent.Soyad1 = txt_soyad.Text;
            ent.Cinsiyet1 = comboBox1.Text;
            ent.Bolumu1 = comboBox2.Text;
            ent.TcNo1 = txt_tc.Text;
            ent.TelefonNo1 = txt_telefon.Text;
            ent.Sifre1 = txt_Sifre.Text;

            int i = LogicLayer.LogicDoktor.LLDoktorEkle(ent);
            if (i == -1)
            {
                MessageBox.Show("Doktor eklenemedi lütfen kontrol ediniz.");
            }
            else
            {
                MessageBox.Show("Doktor Başarıyla eklenmiştir.");
                this.Close();
            }
           
                
                
        


        }

        private void DoktorEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
