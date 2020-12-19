using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Dairy_Management_System.Data_Access_Layer
{
    class DataAccess
    {
        SqlConnection connection;
        SqlCommand command;

        public DataAccess()
        {
            this.connection = new SqlConnection(ConfigurationManager.ConnectionStrings["FinalAsserment"].ConnectionString);
            this.connection.Open();
        }

        public SqlDataReader GetData(string sql)
        {
            this.command = new SqlCommand(sql, this.connection);
            SqlDataReader reader = this.command.ExecuteReader();
            this.connection.Close();
            return reader;

        }
        public int ExecuteQuery(string sql)
        {
            this.command = new SqlCommand(sql, this.connection);
            int result = this.command.ExecuteNonQuery();
            this.connection.Close();
            return result;

        }

    }
}
