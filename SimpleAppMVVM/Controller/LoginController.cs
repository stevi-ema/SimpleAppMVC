using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAppMVVM.Controller
{
    class LoginController
    {
        //declare object utk class model dan view
        Model.Login model; //object class model (Login)
        View.LoginWindow view; //object class view (LoginWindow)

        //variable untuk pesan
        public string pesan;

        //instance -> constructor
        public LoginController(View.LoginWindow view)
        {
            model = new Model.Login();
            this.view = view;
        }

        //request & response -> bentuknya function biasanya void
        public void ValidasiLogin()
        {
            //data -> diambil dari view (input)
            model.username = view.txtUsername.Text;
            model.password = view.txtPassword.Password;
            //result dari mode (true/false)
            bool hasil = model.CheckLogin();
            //response -> view
            if (hasil)
            {
                pesan = "";
                View.HomeWindow home = new View.HomeWindow();
                home.Show();
                view.Close();
            }
            else
            {
                pesan = "Username/Password salah!";
                view.txtUsername.Text = "";
                view.txtPassword.Password = "";
                view.txtUsername.Focus();
            }
        }
    }
}
