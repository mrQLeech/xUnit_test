using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xUnit_test1
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculator();
            Console.WriteLine(5d / 2d);
            Console.WriteLine(calc.Divide(5d, 2d));
            Console.ReadKey();
        }
    }
}
