using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAppMVVM.Model
{
    class Kalkulator
    {
        //atribute -> variabel
        public double nilai1;
        public double nilai2;

        //behavior -> function
        public double Tambah()
        {
            return nilai1 + nilai2;
        }
        public double Kurang()
        {
            return nilai1 - nilai2;
        }
        public double Kali()
        {
            return nilai1 * nilai2;
        }
        public double Bagi()
        {
            return nilai1 / nilai2;
        }
    }
}
