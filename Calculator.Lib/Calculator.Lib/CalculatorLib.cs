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
            var arg1 = a;
            var arg2 = b; 

            var res = arg1 + arg2;
            return res;
        }

        public int Subtract(int a, int b)
        {
            var arg1 = a;
            var arg2 = b;

            var res = arg1 - arg2;
            return res;
        }
    }
}
