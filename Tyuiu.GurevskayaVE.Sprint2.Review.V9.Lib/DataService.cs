using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.GurevskayaVE.Sprint2.Review.V9.Lib
{
    public class DataService 
    {
        public bool Check(double x, double y)
        {
            bool res;
            if (y <= Math.Sin(x) && (y <= 0.5) && (y>=0) && (x>=0) && (x<=Math.PI))
            {
                res = true;
            }
            else res = false;
            return res;
        }
    }
}
