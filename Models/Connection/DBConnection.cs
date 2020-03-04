using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace shad_web_app.Models.Connection
{
    public class DBConnection
    {

        public static SqlConnection getConnection()
        {
            return new SqlConnection(@"Data Source=LAHIRUPC\SQLEXPRESS;Initial Catalog=test1;Integrated Security=True");
        }

    }
}