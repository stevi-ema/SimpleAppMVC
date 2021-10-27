using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAppMVVM.Model
{
    class BangunRuangModel
    {
        private double volume;

        public double GetVolume()
        {
            return volume;
        }

        public void Hitung(double x, double y, double z, string bangun)
        {
            if(bangun == "Balok")
            {
                volume = x * y * z;
            }else if(bangun == "Tabung")
            {
                volume = 3.14 * x * x * y;
            }else if(bangun == "Prisma Segitiga")
            {
                volume = (0.5 * x * y) * z;
            }
            else
            {
                volume = (3.14 * x * x * y) / 3;
            }
        }
    }
}
