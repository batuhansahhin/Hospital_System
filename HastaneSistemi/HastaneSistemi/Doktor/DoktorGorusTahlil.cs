using EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneSistemi.Doktor
{
    public partial class DoktorGorusTahlil : Form
    {
        public DoktorGorusTahlil()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Doktor.DoktorEkranı DoktorEkranı = new Doktor.DoktorEkranı();

            DoktorEkranı.Show();
            this.Hide();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
    
        }

        private void DoktorGorusTahlil_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            label9.Visible = false;
            txt_Id.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Sorgula_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;

            EntityHasta ent = new EntityHasta();
            ent.TcNo1 = txt_tc.Text;

            DataTable i = new DataTable();

            
                i = LogicLayer.LogicHasta.LLHastaAraTc(ent);
                dataGridView1.DataSource = i;
            


        }

        private void button2_Click(object sender, EventArgs e) //güncelle
        {
            EntityLayer.EntityHasta ent = new EntityLayer.EntityHasta();
            ent.HastaNo1 = txt_Id.Text;
            ent.TcNo1 = txt_tc.Text;
            ent.Ad1 = txt_ad.Text;
            ent.Soyad1 = txt_soyad.Text;
            ent.Cinsiyet1 = comboBox1.Text;
            ent.TelefonNo1 = txt_telefon.Text;
            ent.GidilenBolum1 = comboBox2.Text;
            ent.SecilenDoktor1 = comboBox3.Text;
            ent.MailAdresi1 = txt_mail.Text;
            ent.RandevuTarihi1 = dateTimePicker1.Text;
            


            bool a = LogicLayer.LogicHasta.LLHastaGuncelle(ent);
            if (a == false)
            {
                MessageBox.Show("Güncelleme işlemi yapılamamıştır.");
            }
            else
            {
                MessageBox.Show("Güncelleme işlemi Başarıyla yapılmıştır.");
                List<EntityLayer.EntityHasta> HastaList = LogicLayer.LogicHasta.LLHastaGuncelle();
                dataGridView1.DataSource = HastaList;
            }


        }

        private void txt_mail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txt_Id_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
