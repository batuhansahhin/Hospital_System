using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class connection
    {
        public static SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-PKGLM76\SQLEXPRESS;Initial Catalog=HospitalManagament;Integrated Security=True");

    }
}

