using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoapCalculatorUsingDll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoapCalculatorUsingDll.Tests
{
    [TestClass()]
    public class Service1Tests
    {
        public Service1 s;

        [TestInitialize]
        public void BeforeTest()
        {
            s = new Service1();
        }

        [TestMethod()]
        public void DivideTest()
        {
            //arr           
            double expected = 8;
            //act
            double actual = s.Divide(64, 8);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void AddTest()
        {
            //arr          
            double expected = 72;
            //act
            double actual = s.Add(64, 8);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SubtractTest()
        {
            //arr            
            double expected = 56;
            //act
            double actual = s.Subtract(64, 8);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            //arr          
            double expected = 32;
            //act
            double actual = s.Multiply(4, 8);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}