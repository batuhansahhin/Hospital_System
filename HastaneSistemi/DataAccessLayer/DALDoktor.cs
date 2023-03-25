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
    public class DALDoktor
    {
       
        public static int DoktorEkle(EntityDoktor s)
        {
            SqlCommand komut2 = new SqlCommand("Insert into Doktor (Ad,Soyad,Cinsiyet,Bolum,TcNo,TelefonNo,Sifre) VALUES (@s1,@s2,@s3,@s4,@s5,@s6,@s7)", connection.baglanti);

            if (komut2.Connection.State != ConnectionState.Open)
            {

                komut2.Connection.Open();

            }
            komut2.Parameters.AddWithValue("@s1", s.Ad1);
            komut2.Parameters.AddWithValue("@s2", s.Soyad1);
            komut2.Parameters.AddWithValue("@s3", s.Cinsiyet1);
            komut2.Parameters.AddWithValue("@s4", s.Bolumu1);
            komut2.Parameters.AddWithValue("@s5", s.TcNo1);
            komut2.Parameters.AddWithValue("@s6", s.TelefonNo1);
            komut2.Parameters.AddWithValue("@s7", s.Sifre1);

            return komut2.ExecuteNonQuery();
        }

        public static List<EntityDoktor> DoktorListesi()
        {
            List<EntityDoktor> degerler = new List<EntityDoktor>();
            SqlCommand komut1 = new SqlCommand("Select * from Doktor", connection.baglanti);

            if(komut1.Connection.State!= ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            SqlDataReader dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                EntityDoktor ent = new EntityDoktor();
                ent.DoktorNo1 = dr["Id"].ToString();
                ent.Ad1 = dr["Ad"].ToString();
                ent.Soyad1 = dr["Soyad"].ToString();
                ent.Cinsiyet1 = dr["Cinsiyet"].ToString();
                ent.Bolumu1 = dr["Bolum"].ToString();
                ent.TcNo1 = dr["TcNo"].ToString();
                ent.TelefonNo1 = dr["TelefonNo"].ToString();
                ent.Sifre1 = dr["Sifre"].ToString();

                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }

        public static bool DoktorSil(int p)
        {
            SqlCommand komut3 = new SqlCommand("Delete from Doktor Where Id=@P1", connection.baglanti);

            if (komut3.Connection.State != ConnectionState.Open)
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@P1", p);

            return komut3.ExecuteNonQuery() > 0;
        }

        public static bool DoktorGuncelle(EntityDoktor ent)
        {
            SqlCommand komut4 = new SqlCommand("Update Doktor Set Ad=@P1,Soyad=@P2,Cinsiyet=@P3,Bolum=@P4,TcNo=@P5,TelefonNo=@P6 ,Sifre=@P7 Where Id=@P8", connection.baglanti);

            if (komut4.Connection.State != ConnectionState.Open)
            {
                komut4.Connection.Open();
            }
            komut4.Parameters.AddWithValue("@P1", ent.Ad1);
            komut4.Parameters.AddWithValue("@P2", ent.Soyad1);
            komut4.Parameters.AddWithValue("@P3", ent.Cinsiyet1);
            komut4.Parameters.AddWithValue("@P4", ent.Bolumu1);
            komut4.Parameters.AddWithValue("@P5", ent.TcNo1);
            komut4.Parameters.AddWithValue("@P6", ent.TelefonNo1);
            komut4.Parameters.AddWithValue("@P8", ent.DoktorNo1);
            komut4.Parameters.AddWithValue("@P7", ent.Sifre1);

            return komut4.ExecuteNonQuery() > 0;

        }

    }
}
