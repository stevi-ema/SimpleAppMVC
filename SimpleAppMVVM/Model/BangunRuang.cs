using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAppMVVM.Model
{
    class BangunRuang
    {
        //attribute -> var
        public double x;
        public double y;
        public double z;

        //behavior -> func
        public double Balok()
        {
            return (x * y * z);
        }
        public double Tabung()
        {
            return (3.14 * x * x * y);
        }
        public double PrismaSegitiga()
        {
            return ((0.5 * x * y) * z);
        }
        public double Kerucut()
        {
            return (3.14 * x * x * y)/3;
        }
    }
}
