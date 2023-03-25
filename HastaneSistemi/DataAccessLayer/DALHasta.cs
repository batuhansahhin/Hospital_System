using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Data.SqlClient;
using System.Data;
namespace DataAccessLayer
{


    public class DALHasta
    {

        public static bool RaporEkle(EntityHasta s)
        {
            
            SqlCommand komut2 = new SqlCommand("Update Hasta set Rapor=@s1 where ID=@s2", connection.baglanti);
            if (komut2.Connection.State != ConnectionState.Open)
            {

                komut2.Connection.Open();

            }
            komut2.Parameters.AddWithValue("@s1", s.Rapor1);
            komut2.Parameters.AddWithValue("@s2", s.HastaNo1);


            return komut2.ExecuteNonQuery() > 0;



        }
        public static bool TahlilSonucu(EntityHasta s)
        {

            SqlCommand komut2 = new SqlCommand("Update Hasta set TahlilSonucu=@s1 where ID=@s2", connection.baglanti);
            if (komut2.Connection.State != ConnectionState.Open)
            {

                komut2.Connection.Open();

            }
            komut2.Parameters.AddWithValue("@s1", s.TahlilSonucu1);
            komut2.Parameters.AddWithValue("@s2", s.HastaNo1);


            return komut2.ExecuteNonQuery() > 0;



        }

        public static DataTable HastaAraTc(EntityHasta s)
        {
            connection.baglanti.Close();
            connection.baglanti.Open();
            SqlCommand cmd = new SqlCommand("Select * from hasta where TcNo Like '%"+s.TcNo1+"%'", connection.baglanti);
            

            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            DataTable dt = new DataTable();

            dt.Load(dr);
            return dt;

        }

        public static int HastaEkle(EntityHasta s)
        {
            SqlCommand komut2 = new SqlCommand("Insert into Hasta (Ad,Soyad,Cinsiyet,TcNo,TelefonNo,GidilenBolum,SecilenDoktor,MailAdresi,RandevuTarihi) VALUES (@s1,@s2,@s3,@s4,@s5,@s6,@s7,@s8,@s9)", connection.baglanti);

            if (komut2.Connection.State != ConnectionState.Open)
            {

                komut2.Connection.Open();

            }
            komut2.Parameters.AddWithValue("@s1", s.Ad1);
            komut2.Parameters.AddWithValue("@s2", s.Soyad1);
            komut2.Parameters.AddWithValue("@s3", s.Cinsiyet1);
            komut2.Parameters.AddWithValue("@s4", s.TcNo1);
            komut2.Parameters.AddWithValue("@s5", s.TelefonNo1);
            komut2.Parameters.AddWithValue("@s6", s.GidilenBolum1);
            komut2.Parameters.AddWithValue("@s7", s.SecilenDoktor1);
            komut2.Parameters.AddWithValue("@s8", s.MailAdresi1);
            komut2.Parameters.AddWithValue("@s9", s.RandevuTarihi1);




            return komut2.ExecuteNonQuery();
        }

        public static List<EntityHasta> HastaListesi()
        {
            List<EntityHasta> degerler = new List<EntityHasta>();
            SqlCommand komut1 = new SqlCommand("Select * from Hasta", connection.baglanti);

            if (komut1.Connection.State != ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            SqlDataReader dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                EntityHasta ent = new EntityHasta();
                ent.HastaNo1 = dr["Id"].ToString();
                ent.Ad1 = dr["Ad"].ToString();
                ent.Soyad1 = dr["Soyad"].ToString();
                ent.Cinsiyet1 = dr["Cinsiyet"].ToString();
                ent.TcNo1 = dr["TcNo"].ToString();
                ent.TelefonNo1 = dr["TelefonNo"].ToString();

                ent.GidilenBolum1 = dr["GidilenBolum"].ToString();
                ent.SecilenDoktor1 = dr["SecilenDoktor"].ToString();
                ent.MailAdresi1 = dr["MailAdresi"].ToString();
                ent.RandevuTarihi1 = dr["RandevuTarihi"].ToString();



                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }

        public static bool HastaSil(int p)
        {
            SqlCommand komut3 = new SqlCommand("Delete from Hasta Where Id=@P1", connection.baglanti);

            if (komut3.Connection.State != ConnectionState.Open)
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@P1", p);

            return komut3.ExecuteNonQuery() > 0;
        }

        public static bool HastaGuncelle(EntityHasta ent)
        {
            SqlCommand komut4 = new SqlCommand("Update Doktor Set Ad=@P1,Soyad=@P2,Cinsiyet=@P3,TcNo=@P4,TelefonNo=@P5,GidilenBolum=@P6,SecilenDoktor=@P7,MailAdresi=@P8, Rapor=@P9, TahlilSonucu=@P11 Where Id=@P10", connection.baglanti);

            if (komut4.Connection.State != ConnectionState.Open)
            {
                komut4.Connection.Open();
            }
            komut4.Parameters.AddWithValue("@P1", ent.Ad1);
            komut4.Parameters.AddWithValue("@P2", ent.Soyad1);
            komut4.Parameters.AddWithValue("@P3", ent.Cinsiyet1);
            komut4.Parameters.AddWithValue("@P4", ent.TcNo1);
            komut4.Parameters.AddWithValue("@P5", ent.TelefonNo1);
            komut4.Parameters.AddWithValue("@P6", ent.GidilenBolum1);
            komut4.Parameters.AddWithValue("@P7", ent.SecilenDoktor1);
            komut4.Parameters.AddWithValue("@P8", ent.MailAdresi1);
            komut4.Parameters.AddWithValue("@P9", ent.Rapor1);
            komut4.Parameters.AddWithValue("@P11", ent.TahlilSonucu1);
            komut4.Parameters.AddWithValue("@P10", ent.HastaNo1);

            return komut4.ExecuteNonQuery() > 0;

        }
    }
}
