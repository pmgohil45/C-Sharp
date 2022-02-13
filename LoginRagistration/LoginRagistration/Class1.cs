using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
namespace LoginRagistration
{
    class Class1
    {
        public static SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\login.mdf;Integrated Security=True");
        public static DataTable dt = new DataTable();
    }
}
