using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xUnit_test1
{
    public class Calculator
    {
        public int AddInts(int a, int b)
        {
            return a + b;
        }

        public double AddDoubles(double a, double b)
        {
            return a + b;
        }

        public double Divide (double value, double by)
        {
            return value / (double)by;
        }


    }
}
