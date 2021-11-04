using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAppMVVM.Model
{
    class Login
    {
        //attribute -> variabel
        public string username;
        public string password;

        //behavior -> function
        public bool CheckLogin()
        {
            bool result;
            if(username == "stevi" && password == "admin")
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }
    }
}
