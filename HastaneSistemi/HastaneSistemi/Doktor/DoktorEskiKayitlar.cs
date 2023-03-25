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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HastaneSistemi.Doktor
{
    public partial class DoktorEskiKayitlar : Form
    {
        public DoktorEskiKayitlar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Doktor.DoktorEkranı DoktorEkranı = new Doktor.DoktorEkranı();

            DoktorEkranı.Show();
            this.Hide();
        }

        private void DoktorEskiKayitlar_Load(object sender, EventArgs e)
        {
            List<EntityLayer.EntityHasta> HastaList = LogicLayer.LogicHasta.LLHastaGuncelle();
            dataGridView1.DataSource = HastaList;
            
        }

        private void btn_goruntule_Click(object sender, EventArgs e)
        {


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_tc_TextChanged(object sender, EventArgs e)
        {
            EntityHasta ent = new EntityHasta();
            ent.TcNo1 = txt_tc.Text;

            DataTable i = new DataTable();

            if (ent.TcNo1 != null)
            {
                i = LogicLayer.LogicHasta.LLHastaAraTc(ent);
                dataGridView1.DataSource = i;
            }

            
          
        }

        private void sorgula_Click(object sender, EventArgs e)
        {

        }

        private void yenile_Click(object sender, EventArgs e)
        {
            List<EntityLayer.EntityHasta> HastaList = LogicLayer.LogicHasta.LLHastaGuncelle();
            dataGridView1.DataSource = HastaList;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
