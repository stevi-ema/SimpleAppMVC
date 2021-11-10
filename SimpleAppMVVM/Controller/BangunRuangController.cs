using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAppMVVM.Controller
{
    class BangunRuangController
    {
        //declare object dr class model dan view
        Model.BangunRuang model;
        View.BangunRuangPage view;

        //instance -> constructor
        public BangunRuangController(View.BangunRuangPage view)
        {
            model = new Model.BangunRuang();
            this.view = view;
        }

        //request & response -> void function
        public void VolumeBalok()
        {
            //input
            model.x = Double.Parse(view.txtSisi1.Text);
            model.y = Double.Parse(view.txtSisi2.Text);
            model.z = Double.Parse(view.txtSisi3.Text);
            //response
            view.lblHasil.Content = model.Balok();
        }
    }
}
