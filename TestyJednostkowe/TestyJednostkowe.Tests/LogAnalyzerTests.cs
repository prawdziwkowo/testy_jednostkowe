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
    public class LogAnalyzerTests
    {

        private LogAnalyzer logAnalyzer;

        [SetUp]
        public void Setup()
        {
            logAnalyzer = new LogAnalyzer();
           // Console.WriteLine("SetUp");
        }

        [TestCase("hsdjfhf.SLF", true)]
        [TestCase("hsdjfhf.slf", true)]
        [TestCase("hsdjfhf.foo", false)]
        public void IsValidFileName_ValidExtension_CheckThem(String fileName, bool expected)
        {
            bool results = logAnalyzer.IsValidLogFileName(fileName);
            Assert.AreEqual(expected, results);
        }

        [Test]
        [Category("Dupa")]
        public void IsValidFileName_EmptyFileName_Throws()
        {
            var ex = Assert.Throws<ArgumentException>(() => logAnalyzer.IsValidLogFileName("")); //to jest wyrażenie lambda, po lewej argumenty po prawej tresc
            StringAssert.Contains("Podaj nazwę pliku", ex.Message);
        }

        [Test]
        [Category("Dupa")]
        public void IsValidFileName_EmptyFileName_ThrowsFluent()
        {
            LogAnalyzer la = new LogAnalyzer();
            var ex = Assert.Throws<ArgumentException>(() => la.IsValidLogFileName(""));
            Assert.That(ex.Message, Does.Contain("Podaj nazwę pliku"));
        }


        [TestCase("hsdjfhf.SLF", true)]
        [TestCase("hsdjfhf.slf", true)]
        [TestCase("hsdjfhf.foo", false)]
        public void IsValidFileName_WhenCalled_ChangesWasLastFileNameValid(string file, bool expected)
        {
            LogAnalyzer2 la = new LogAnalyzer2();
            la.IsValidLogFileName(file);
            Assert.AreEqual(expected, la.wasLastFileNameIsValid);
        }

        [Test]
        [Ignore("Ignorujemy lalalalala")]
        public void IgnoreTest()
        {

        }

        [TearDown]
        public void TearDown()
        {

        }
        
    }
}
