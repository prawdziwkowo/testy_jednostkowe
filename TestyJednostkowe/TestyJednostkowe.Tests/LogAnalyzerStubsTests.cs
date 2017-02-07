using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestyJednostkowe;

namespace TestyJednostkowe.Tests
{
    [TestFixture]
    class LogAnalyzerStubsTests
    {
        [Test]
        public void IsValidFileName_nameSupportedExtention_ReturnsTrue()
        {
            FakeExtentionManager fakeManger = new FakeExtentionManager();
            fakeManger.willBeValid = true;

            LogAnalyzerStubs log = new LogAnalyzerStubs(fakeManger);
            Assert.True(log.isValidLogFileName("plik.ext"));

        }
        
        [Test]
        public void IsValidFileName_ExtManagerThrowsException_Throws()
        {
            string exceptionMessage = "Wyjątek jakiś normalnie o tej porze";
            FakeExtentionManager fakeManger = new FakeExtentionManager();
            fakeManger.willThrow = new Exception("Wyjątek jakiś normalnie o tej porze");
            LogAnalyzerStubs log = new LogAnalyzerStubs(fakeManger);
            var ex = Assert.Throws<Exception>(() => log.isValidLogFileName("anything.anything")); //to jest wyrażenie lambda, po lewej argumenty po prawej tresc
            StringAssert.Contains(exceptionMessage, ex.Message);
        }
    }

    internal class FakeExtentionManager : IExtentionManager
    {
        public bool willBeValid = false;
        public Exception willThrow = null;
        public bool isValid(string fileName)
        {
            if (willThrow != null)
            {
                throw willThrow;
            }
            return willBeValid;
        }
    }
}
