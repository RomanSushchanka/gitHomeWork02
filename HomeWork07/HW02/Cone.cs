using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW02
{
    public class Cone
    {
        double _r;
        double _h;
        public Cone(double r, double h)
        {
            this._r = r;
            this._h = h;
        }

        public double CalcBaseArea()
        {
            return Math.PI * _r * _r;
        }

        public double CalcTotalArea()
        {
            double baseArea = CalcBaseArea();
            double slantHeight = Math.Sqrt(_r * _r + _h * _h);
            return baseArea + Math.PI * _r * slantHeight;
        }
    }
}
