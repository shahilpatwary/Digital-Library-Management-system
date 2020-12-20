using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Dairy_Management_System.Data_Access_Layer
{
    class UserRegistratinDataAccess
    {
        DataAccess dataAccess;
        public UserRegistratinDataAccess()
        {
            this.dataAccess = new DataAccess();
        }

        public bool LoginValidation(string userName,string password)
        {
            string sql = "SELECT * FROM Users WHERE UserName='" + userName + "'and Password='" + password + "'";
            SqlDataReader reader = dataAccess.GetData(sql);
            if(reader.Read())
            {
                return true;
            }
            return false;
        }
    }
}
