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
    public partial class SekreterGuncelleSil : Form
    {
        public SekreterGuncelleSil()
        {
            InitializeComponent();
        }
        public void textboxlariSil()
        {
            txt_Id.Text = "";
            txt_tc.Text = "";
            txt_ad.Text = "";
            txt_soyad.Text = "";
            comboBox1.SelectedIndex = -1;
            txt_telefon.Text = "";
            
        }
        private void SekreterGuncelleSil_Load(object sender, EventArgs e)
        {
            List<EntityLayer.EntitySekreter> SekList = LogicLayer.LogicSekreter.LLSekreterListele();
            dataGridView1.DataSource = SekList;
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            EntityLayer.EntitySekreter ent = new EntityLayer.EntitySekreter();
            ent.SekreterNo1 = txt_Id.Text;
            int Id = Int32.Parse(ent.SekreterNo1);

            bool a = LogicLayer.LogicSekreter.LLSekreterSil(Id);

            if (a == false)
            {
                MessageBox.Show("Silme işlemi gerçekleşemedi.");
            }
            else
            {
                List<EntityLayer.EntitySekreter> SekList = LogicLayer.LogicSekreter.LLSekreterListele();
                dataGridView1.DataSource = SekList;
                textboxlariSil();
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            EntityLayer.EntitySekreter ent = new EntityLayer.EntitySekreter();
            ent.SekreterNo1 = txt_Id.Text;
            ent.Ad1 = txt_ad.Text;
            ent.Soyad1 = txt_soyad.Text;
            ent.Cinsiyet1 = comboBox1.Text;
            ent.TcNo1 = txt_tc.Text;
            ent.TelefonNo1 = txt_telefon.Text;

            bool a = LogicLayer.LogicSekreter.LLSekreterGuncelle(ent);
            if (a == false)
            {
                MessageBox.Show("Güncelleme işlemi yapılamamıştır.");
            }
            else
            {
                MessageBox.Show("Güncelleme işlemi Başarıyla yapılmıştır.");
                List<EntityLayer.EntitySekreter> SekList = LogicLayer.LogicSekreter.LLSekreterListele();
                dataGridView1.DataSource = SekList;
                textboxlariSil();
            }
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

                
               
            }
        }


    }
}
