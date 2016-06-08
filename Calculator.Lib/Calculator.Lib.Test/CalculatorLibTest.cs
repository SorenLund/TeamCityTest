using NUnit.Framework;
using Calculator.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Lib.Test
{
    [TestFixture()]
    public class CalculatorLibTest
    {
        private CalculatorLib _calc;

        [SetUp]
        public void MainSetUp()
        {
            _calc = new CalculatorLib();
        }

        [TestFixture()]
        public class AddMethod : CalculatorLibTest
        {
            [Test]
            public void Given5and5_ThenReturn10()
            {
                var res = _calc.Add(5, 5);
                Assert.AreEqual(10, res);
            }
        }

        [TestFixture()]
        public class SubtractMethod : CalculatorLibTest
        {
            [Test]
            public void Given5and5_ThenReturn0()
            {
                var res = _calc.Subtract(5, 5);
                Assert.AreEqual(0, res);
            }
        }
    }
}