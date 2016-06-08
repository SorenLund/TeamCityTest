using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Lib
{
    public class CalculatorLib
    {
        public int Add(int a, int b)
        {
            var res = a + b;
            return res;
        }

        public int Subtract(int a, int b)
        {
            var res = a - b;
            return res;
        }
    }
}
