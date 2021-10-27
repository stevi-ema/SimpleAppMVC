using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAppMVVM.Model
{
    class LoginModel
    {
        private bool hasil;

        public void CheckLogin(string username, string password)
        {
            if(username == "stevi" && password == "amikom")
            {
                hasil = true;
            }
            else
            {
                hasil = false;
            }
        }

        public bool GetHasil()
        {
            return hasil;
        }
    }
}
