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
    public class DALSekreter
    {


        /* public static int SekreterEkle(EntitySekreter s)
         {
             SqlCommand komut2 = new SqlCommand("Insert into Sekreter (TcNo,Ad,Soyad,DogumTarihi,TelefonNo,Cinsiyet) VALUES (@s1,@s2,@s3,@s4,@s5,@s6)", connection.baglanti);

             if (komut2.Connection.State != ConnectionState.Open)
             {

                 komut2.Connection.Open();

             }
             komut2.Parameters.AddWithValue("@s1", s.TcNo1);
             komut2.Parameters.AddWithValue("@s2", s.Ad1);
             komut2.Parameters.AddWithValue("@s3", s.Soyad1);
             komut2.Parameters.AddWithValue("@s4", s.DogumTarihi1);
             komut2.Parameters.AddWithValue("@s5", s.TelefonNo1);
             komut2.Parameters.AddWithValue("@s6", s.Cinsiyet1);


             return komut2.ExecuteNonQuery();


         }*/


        public static int SekreterEkle(EntitySekreter s)
        {
            SqlCommand komut2 = new SqlCommand("Insert into Sekreter (Ad,Soyad,Cinsiyet,TcNo,TelefonNo,Sifre) VALUES (@s1,@s2,@s3,@s4,@s5,@s6)", connection.baglanti);

            if (komut2.Connection.State != ConnectionState.Open)
            {

                komut2.Connection.Open();

            }
            komut2.Parameters.AddWithValue("@s1", s.Ad1);
            komut2.Parameters.AddWithValue("@s2", s.Soyad1);
            komut2.Parameters.AddWithValue("@s3", s.Cinsiyet1);
            komut2.Parameters.AddWithValue("@s4", s.TcNo1);
            komut2.Parameters.AddWithValue("@s5", s.TelefonNo1);
            komut2.Parameters.AddWithValue("@s6", s.Sifre1);
            return komut2.ExecuteNonQuery();
        }

        public static List<EntitySekreter> SekreterListesi()
        {
            List<EntitySekreter> degerler = new List<EntitySekreter>();
            SqlCommand komut1 = new SqlCommand("Select * from Sekreter", connection.baglanti);

            if (komut1.Connection.State != ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            SqlDataReader dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                EntitySekreter ent = new EntitySekreter();
                ent.SekreterNo1 = dr["Id"].ToString();
                ent.Ad1 = dr["Ad"].ToString();
                ent.Soyad1 = dr["Soyad"].ToString();
                ent.Cinsiyet1 = dr["Cinsiyet"].ToString();
                ent.TcNo1 = dr["TcNo"].ToString();
                ent.TelefonNo1 = dr["TelefonNo"].ToString();
                ent.Sifre1 = dr["Sifre"].ToString();
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }

        public static bool SekreterSil(int p)
        {
            SqlCommand komut3 = new SqlCommand("Delete from Sekreter Where Id=@P1", connection.baglanti);

            if (komut3.Connection.State != ConnectionState.Open)
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@P1", p);

            return komut3.ExecuteNonQuery() > 0;
        }

        public static bool SekreterGuncelle(EntitySekreter ent)
        {
            SqlCommand komut4 = new SqlCommand("Update Sekreter Set Ad=@P1,Soyad=@P2,Cinsiyet=@P3,TcNo=@P4,TelefonNo=@P5 , Sifre=@P6 Where Id=@P7", connection.baglanti);

            if (komut4.Connection.State != ConnectionState.Open)
            {
                komut4.Connection.Open();
            }
            komut4.Parameters.AddWithValue("@P1", ent.Ad1);
            komut4.Parameters.AddWithValue("@P2", ent.Soyad1);
            komut4.Parameters.AddWithValue("@P3", ent.Cinsiyet1);
            komut4.Parameters.AddWithValue("@P4", ent.TcNo1);
            komut4.Parameters.AddWithValue("@P5", ent.TelefonNo1);
            komut4.Parameters.AddWithValue("@P6", ent.Sifre1);
            komut4.Parameters.AddWithValue("@P7", ent.SekreterNo1);
            komut4.Parameters.AddWithValue("@P7", ent.SekreterNo1);

            return komut4.ExecuteNonQuery() > 0;

        }
    }
}

