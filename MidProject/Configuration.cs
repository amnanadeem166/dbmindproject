using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CRUD_Operations
{
    class Configurations
    {
        String ConnectionStr = @"Data Source=(local);Initial Catalog=ProjectB;Integrated Security=True";
        SqlConnection con;
        private static Configurations _instance;
        public static Configurations getInstance()
        {
            if (_instance == null)
                _instance = new Configurations();
            return _instance;
        }
        private Configurations()
        {
            con = new SqlConnection(ConnectionStr);
            con.Open();
        }
        public SqlConnection getConnection()
        {
            return con;
        }
    }
}






