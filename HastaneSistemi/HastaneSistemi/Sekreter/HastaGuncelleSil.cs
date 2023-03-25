using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneSistemi.Sekreter
{
    public partial class HastaGuncelleSil : Form
    {
        public HastaGuncelleSil()
        {
            InitializeComponent();
        }

        private void HastaGuncelleSil_Load(object sender, EventArgs e)
        {
            List<EntityLayer.EntityHasta> HastaList = LogicLayer.LogicHasta.LLHastaGuncelle();
            dataGridView1.DataSource = HastaList;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvRow = dataGridView1.Rows[e.RowIndex];

                txt_Id.Text = dgvRow.Cells[0].Value.ToString();
                txt_tc.Text = dgvRow.Cells[1].Value.ToString();
                txt_ad.Text = dgvRow.Cells[2].Value.ToString();
                txt_soyad.Text = dgvRow.Cells[3].Value.ToString();
                comboBox1.Text = dgvRow.Cells[4].Value.ToString();
                txt_telefon.Text = dgvRow.Cells[5].Value.ToString();

                comboBox2.Text = dgvRow.Cells[6].Value.ToString();
                comboBox3.Text = dgvRow.Cells[7].Value.ToString();
                txt_mail.Text = dgvRow.Cells[8].Value.ToString();
                dateTimePicker1.Text = dgvRow.Cells[9].Value.ToString();



            }
        }
        public void textboxlariSil()
        {
            txt_Id.Text = "";
            txt_tc.Text = "";
            txt_ad.Text = "";
            txt_soyad.Text = "";
            comboBox1.SelectedIndex = -1;
            txt_telefon.Text = "";
            comboBox2.SelectedIndex = -1;
        }
        private void btn_Sil_Click(object sender, EventArgs e)
        {
            EntityLayer.EntityHasta ent = new EntityLayer.EntityHasta();
            ent.HastaNo1 = txt_Id.Text;
            int Id = Int32.Parse(ent.HastaNo1);

            bool a = LogicLayer.LogicHasta.LLHastaSil(Id);

            if (a == false)
            {
                MessageBox.Show("Silme işlemi gerçekleşemedi.");
            }
            else
            {
                List<EntityLayer.EntityHasta> HastaList = LogicLayer.LogicHasta.LLHastaGuncelle();
                dataGridView1.DataSource = HastaList;
                textboxlariSil();
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
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
                textboxlariSil();
            }



        }

        private void btn_guncelle_Click_1(object sender, EventArgs e)
        {

        }
    }
}
