using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAppMVVM.Controller
{
    class KalkulatorController
    {
        //declare object utk class model dan view
        Model.Kalkulator model;
        View.KalkulatorPage view;

        //instance -> constructor
        public KalkulatorController(View.KalkulatorPage view)
        {
            model = new Model.Kalkulator();
            this.view = view;
        }

        //function input data
        void InputData()
        {
            model.nilai1 = Double.Parse(view.txtNilai1.Text);
            model.nilai2 = Double.Parse(view.txtNilai2.Text);
        }
        //request + response -> void function
        public void Penjumlahan()
        {
            //input data
            InputData();
            //result dr model -> response ke view
            view.lblHasil.Content = model.Tambah();
        }
        public void Pengurangan()
        {
            //input data
            InputData();
            //result dr model -> response ke view
            view.lblHasil.Content = model.Kurang();
        }
        public void Perkalian()
        {
            //input data
            InputData();
            //result dr model -> response ke view
            view.lblHasil.Content = model.Kali();
        }
        public void Pembagian()
        {
            //input data
            InputData();
            //result dr model -> response ke view
            view.lblHasil.Content = model.Bagi();
        }
    }
}
