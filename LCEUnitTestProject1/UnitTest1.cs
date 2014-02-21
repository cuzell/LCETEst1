using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LCEUnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCount()
        {
            LCETEst1.FizzBuzz fizzBuzz = new LCETEst1.FizzBuzz { start = 1, stop = 100 };
            Assert.IsTrue(fizzBuzz.writeNumbers().ToList().Count == 100);
        }
        [TestMethod]
        [ExpectedException(typeof(ApplicationException), "The data is too large, please use IEnumerable overload")]
        public void TestOOMException()
        {
            LCETEst1.FizzBuzz fizzBuzz = new LCETEst1.FizzBuzz();
            var s = fizzBuzz.writeNumbers(1, 2000000000);
        }
        [TestMethod]
        public void TestDifferentPrintOut()
        {
            LCETEst1.FizzBuzz fizzBuzz = new LCETEst1.FizzBuzz { start = 1, stop = 3, Fizz = "New Text" };
            Assert.IsNotNull(fizzBuzz.writeNumbers().FirstOrDefault(s => s == "New Text"));
        }
    }
}
