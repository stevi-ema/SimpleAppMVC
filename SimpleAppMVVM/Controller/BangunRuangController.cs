using SimpleAppMVVM.Model;
using SimpleAppMVVM.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAppMVVM.Controller
{
    class BangunRuangController
    {
        private BangunRuangModel model;
        private BangunRuangPage view;

        public BangunRuangController(BangunRuangPage view)
        {
            this.view = view;
            model = new BangunRuangModel();
        }

        public void Hasil()
        {
            model.Hitung(Double.Parse(view.txtSisi1.Text), Double.Parse(view.txtSisi2.Text), 
                Double.Parse(view.txtSisi3.Text), view.bangun);
            view.lblHasil.Content = model.GetVolume().ToString();
        }
    }
}
