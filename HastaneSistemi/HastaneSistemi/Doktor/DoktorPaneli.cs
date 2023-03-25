using EntityLayer;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneSistemi.Doktor
{
    public partial class DoktorPaneli : Form
    {
        public DoktorPaneli()
        {
            InitializeComponent();
        }

        private void DoktorPaneli_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'hospitalManagamentDataSet1.Hasta' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.hastaTableAdapter1.Fill(this.hospitalManagamentDataSet1.Hasta);
            // TODO: Bu kod satırı 'hospitalManagamentDataSet.Hasta' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.hastaTableAdapter.Fill(this.hospitalManagamentDataSet.Hasta);


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

        private void yenile_Click(object sender, EventArgs e)
        {
            List<EntityLayer.EntityHasta> HastaList = LogicLayer.LogicHasta.LLHastaGuncelle();
            dataGridView1.DataSource = HastaList;
        }

        private void button_sorgula_tahlil_Click(object sender, EventArgs e)
        {
            dataGridView2.Visible = false;
            

            if(txt_tc != null)
            {
                dataGridView2.Visible = true;
            }
            else
            {

            }
            EntityHasta ent = new EntityHasta();
            ent.TcNo1 = txt_tc.Text;

            
            DataTable i = new DataTable();


            i = LogicLayer.LogicHasta.LLHastaAraTc(ent);
            dataGridView2.DataSource = i;
        }


        private void btn_ekle_Click(object sender, EventArgs e)
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
            ent.Rapor1 = textBox1.Text;
            ent.TahlilSonucu1 = textBox_TahlilSonucu.Text;


            bool a = LogicLayer.LogicHasta.RaporEkle(ent);
            if (a == false)
            {
                MessageBox.Show("Güncelleme işlemi yapılamamıştır. " + "Hasta ID kontrolünü yapınız!");
            }
            else
            {
                MessageBox.Show("Güncelleme işlemi Başarıyla yapılmıştır.");
                List<EntityLayer.EntityHasta> HastaList = LogicLayer.LogicHasta.LLHastaGuncelle();
                dataGridView1.DataSource = HastaList;
            }

            bool b = LogicLayer.LogicHasta.TahlilSonucu(ent);
            if (b == false)
            {
                MessageBox.Show("Güncelleme işlemi yapılamamıştır. " + "Hasta ID kontrolünü yapınız!");
            }
            else
            {
                MessageBox.Show("Güncelleme işlemi Başarıyla yapılmıştır.");
                List<EntityLayer.EntityHasta> HastaList = LogicLayer.LogicHasta.LLHastaGuncelle();
                dataGridView1.DataSource = HastaList;
            }
        }

        private void button_pdf_Click(object sender, EventArgs e)
        {
                if (dataGridView2.Rows.Count > 0)
                {
                    SaveFileDialog save = new SaveFileDialog();
                    save.Filter = "PDF (*.pdf)|*.pdf";
                    save.FileName = "Result.pdf";
                    BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, "CP1254", BaseFont.NOT_EMBEDDED);
                    iTextSharp.text.Font font = new iTextSharp.text.Font(bf, 15, iTextSharp.text.Font.NORMAL);
                bool ErrorMessage = false;
                    if (save.ShowDialog() == DialogResult.OK)
                    {
                        if (File.Exists(save.FileName))
                        {
                            try
                            {
                                File.Delete(save.FileName);
                            }
                            catch (Exception ex)
                            {
                                ErrorMessage = true;
                                MessageBox.Show("PDF kaydedilirken hata ile karşılaşıldı." + ex.Message);
                            }
                        }
                        if (!ErrorMessage)
                        {
                            try
                            {
                                PdfPTable pTable = new PdfPTable(dataGridView2.Columns.Count);
                                pTable.DefaultCell.Padding = 2;
                                pTable.WidthPercentage = 100;
                                pTable.HorizontalAlignment = Element.ALIGN_LEFT;
                                foreach (DataGridViewColumn col in dataGridView2.Columns)
                                {
                                    PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                    pTable.AddCell(pCell);
                                }
                                foreach (DataGridViewRow viewRow in dataGridView2.Rows)
                                {
                                    foreach (DataGridViewCell dcell in viewRow.Cells)
                                    {
                                        pTable.AddCell(dcell.Value.ToString());
                                    }
                                }
                                using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                                {
                                    Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);
                                    PdfWriter.GetInstance(document, fileStream);
                                    document.Open();
                                    document.Add(pTable);
                                    document.Close();
                                    fileStream.Close();
                                }
                                MessageBox.Show("PDF başarıyla kayıt edildi", "info");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("PDF kayıt edilirken hata ile karşılaşıldı." + ex.Message);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Kayıt bulunamadı", "Info");
                }
            }


        private void button_hastapdf_Click(object sender, EventArgs e)
        {
            
            if (txt_Id.Text != "" && textBox1.Text != "")
                {
                    string pdfstring =  Environment.NewLine + "Hastanın Adı Soyadı: " + txt_ad.Text + " " + txt_soyad.Text + Environment.NewLine + "Hasta Tc No: " + textBox2.Text + Environment.NewLine
                        + "Hasta Mail Adresi: " + txt_mail.Text + Environment.NewLine + "Hasta Telefon Numarası: " + txt_telefon.Text + Environment.NewLine + "Hasta Raporu: " + textBox1;

                    SaveFileDialog file = new SaveFileDialog();
                    file.Filter = "PDF DOSYALARI(*.pdf) | *.pdf";
                    file.Title = "PDF DOSYASI OLUŞTURMA";
                    file.FileName = textBox2.Text + "Rapor" + DateTime.Now.ToString("MM/dd/yyyy");
                    if (file.ShowDialog() == DialogResult.OK)
                    {
                        FileStream dosya = File.Open(file.FileName, FileMode.Create);
                        Document pdf = new Document();
                        PdfWriter.GetInstance(pdf, dosya);
                        pdf.Open();
                        pdf.AddTitle(textBox2 + "_Rapor");
                        pdf.AddSubject(textBox2 + "_Rapor");
                        pdf.AddKeywords(textBox2 + "_Rapor");
                        pdf.AddCreationDate();
                        BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, "CP1254", BaseFont.NOT_EMBEDDED);
                        iTextSharp.text.Font font = new iTextSharp.text.Font(bf, 15, iTextSharp.text.Font.NORMAL);
                        Paragraph paragraph = new Paragraph(pdfstring, font);
                        pdf.Add(paragraph);
                        pdf.Close();
                        MessageBox.Show("Pdf başarıyla kaydedilmiştir.");

                    }
                }
                else
                {
                    if (txt_Id.Text == "")
                    {
                        MessageBox.Show("Lütfen bir hasta seçiniz.");
                    }
                    else
                    {
                        MessageBox.Show("Seçmiş olduğunuz hastanın bilgilerini tam girmediniz.");
                    }
                }
            }

        private void button_mail_Click(object sender, EventArgs e)
        {

                if (txt_Id.Text != "" && txt_mail.Text != "")
                {
                    try
                    {
                        string pdfstring = "DOKTOR ADI SOYADI: " + comboBox3 + " " + "DOKTOR BRANŞI: " + comboBox2 + Environment.NewLine
                           + Environment.NewLine + "Hastanın Adı Soyadı: " + txt_ad.Text + " " + txt_soyad.Text + Environment.NewLine + "Hasta Tc No: " + textBox2.Text + Environment.NewLine
                           + "Hasta Mail Adresi: " + txt_mail.Text + Environment.NewLine + "Hasta Telefon Numarası: " + txt_telefon.Text + Environment.NewLine
                           + "Hasta Raporu: " + textBox1;
                        MailMessage mesajım = new MailMessage();
                        SmtpClient istemci = new SmtpClient();
                        istemci.Credentials = new System.Net.NetworkCredential("duzcegorselprogramlama@outlook.com", "emirozturk2001");
                        istemci.Port = 587;
                        istemci.Host = "smtp-mail.outlook.com";
                        istemci.EnableSsl = true;
                        mesajım.To.Add(txt_mail.Text);
                        mesajım.From = new MailAddress("duzcegorselprogramlama@outlook.com");
                        mesajım.Subject = textBox2.Text + " " + txt_ad.Text + " " + txt_soyad.Text + " Hastane Raporu";
                        mesajım.Body = pdfstring;
                        istemci.Send(mesajım);
                        MessageBox.Show("Mail başarıyla gönderilmiştir.");
                    }
                    catch
                    {
                        MessageBox.Show("Mail gönderme işlemi başarısız. Lütfen internet bağlantınızı kontrol ediniz.");
                    }

                }
                else
                {
                    if (txt_Id.Text == "")
                    {
                        MessageBox.Show("Lütfen bir hasta seçiniz.");
                    }
                    else if (txt_mail.Text == "")
                    {
                        MessageBox.Show("Seçmiş olduğunuz hastanın bir mail adresi bulunmamaktadır.");
                    }

                }
            }


            private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox_TahlilSonucu_TextChanged(object sender, EventArgs e)
        {

        }

        private void sorgula_Click(object sender, EventArgs e)
        {

        }
    }
}
