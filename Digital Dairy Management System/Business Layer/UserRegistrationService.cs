using Digital_Dairy_Management_System.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Dairy_Management_System.Business_Layer
{
    class UserRegistrationService
    {
        UserRegistratinDataAccess userDataAccess;
        public UserRegistrationService()
        {
            this.userDataAccess = new UserRegistratinDataAccess();
        }
        public bool LoginValidation(string userName, string password)
        {
            return userDataAccess.LoginValidation(userName,password);
        }
    }
}
