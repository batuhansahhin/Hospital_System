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
    public class DALPoliklinik
    {
        public static List<EntityPoliklinik> PoliklinikListesi()
        {
            List<EntityPoliklinik> PoliklinikListeleme = new List<EntityPoliklinik>();
            SqlCommand komut1 = new SqlCommand("SELECT * FROM Poliklinik", connection.baglanti);
            if (komut1.Connection.State != ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            SqlDataReader dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                EntityPoliklinik entPoliklinik = new EntityPoliklinik();
                entPoliklinik.PoliklinikId1 = int.Parse(dr["PoliklinikId"].ToString());
                entPoliklinik.PoliklinikAdi1 = dr["PoliklinikAdi"].ToString();
                PoliklinikListeleme.Add(entPoliklinik);

            }
            dr.Close();
            return PoliklinikListeleme;
        }
    }
}
