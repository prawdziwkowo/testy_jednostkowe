using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestyJednostkowe;

namespace TestyJednostkowe.Tests
{
    class MemCalculatorTests
    {
        [Test]
        public void Sum_Default_ReturnsZero()
        {
            MemCalculator calc = new MemCalculator();
            Assert.AreEqual(0, calc.Sum());
        }

        [Test]
        public void Add_WhenCalled_ChangesSum()
        {
            MemCalculator calc = new MemCalculator();
            calc.Add(1);
            Assert.AreEqual(1, calc.Sum());
        }

    }
}
