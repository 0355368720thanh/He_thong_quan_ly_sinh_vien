using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CMS
{
    internal class Database
    {
        protected static string getStrconnection()
        {
            string strConnection = @"Data Source=LAPTOP-NN8LKB4S\SQLEXPRESS;Initial Catalog=CMS SYSTEMS;Integrated Security=True";
            return strConnection;
        }
        public static SqlConnection GetConnection()
        {
            string strConnection = Database.getStrconnection();
            SqlConnection conn = new SqlConnection(strConnection);
            return conn;
        }
        public static string RoleName;
    }
}
