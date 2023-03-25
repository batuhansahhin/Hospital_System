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
    public partial class DoktorGuncelleSil : Form
    {
        public DoktorGuncelleSil()
        {
            InitializeComponent();
        }

        private void DoktorGuncelleSil_Load(object sender, EventArgs e)
        {
            List<EntityLayer.EntityDoktor> DokList = LogicLayer.LogicDoktor.LLDoktorListele();
            dataGridView1.DataSource = DokList;
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            EntityLayer.EntityDoktor ent = new EntityLayer.EntityDoktor();
            ent.DoktorNo1 = txt_Id.Text;
            int Id = Int32.Parse(ent.DoktorNo1);
            
            bool a = LogicLayer.LogicDoktor.LLDoktorSil(Id);

            if (a == false)
            {
                MessageBox.Show("Silme işlemi gerçekleşemedi.");
            }
            else
            {
                List<EntityLayer.EntityDoktor> DokList = LogicLayer.LogicDoktor.LLDoktorListele();
                dataGridView1.DataSource = DokList;
                textboxlariSil();
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
            comboBox2.SelectedIndex=-1;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow dgvRow = dataGridView1.Rows[e.RowIndex];

                txt_Id.Text = dgvRow.Cells[0].Value.ToString();
                txt_tc.Text = dgvRow.Cells[1].Value.ToString();
                txt_ad.Text = dgvRow.Cells[2].Value.ToString();
                txt_soyad.Text = dgvRow.Cells[3].Value.ToString();
                comboBox1.Text = dgvRow.Cells[4].Value.ToString();
                txt_telefon.Text = dgvRow.Cells[5].Value.ToString();
                comboBox2.Text = dgvRow.Cells[6].Value.ToString();
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            EntityLayer.EntityDoktor ent = new EntityLayer.EntityDoktor();
            ent.DoktorNo1 = txt_Id.Text;
            ent.Ad1 = txt_ad.Text;
            ent.Soyad1 = txt_soyad.Text;
            ent.Cinsiyet1 = comboBox1.Text;
            ent.Bolumu1 = comboBox2.Text;
            ent.TcNo1 = txt_tc.Text;
            ent.TelefonNo1 = txt_telefon.Text;
            
            bool a = LogicLayer.LogicDoktor.LLDoktorGuncelle(ent);
            if (a == false)
            {
                MessageBox.Show("Güncelleme işlemi yapılamamıştır.");
            }
            else
            {
                MessageBox.Show("Güncelleme işlemi Başarıyla yapılmıştır.");
                List<EntityLayer.EntityDoktor> DokList = LogicLayer.LogicDoktor.LLDoktorListele();
                dataGridView1.DataSource = DokList;
                textboxlariSil();
            }

            

        }
    }
}
