using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab1_forms.Form1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_forms.Form1.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void getresultTest1()
        {
            var n = 1215;
            var Out = Logic.getresult(n);
            Assert.AreEqual("12 рублей 15 копеек", Out);
        }
        [TestMethod()]
        public void getresultTest2()
        {
            var n = 1403;
            var Out = Logic.getresult(n);
            Assert.AreEqual("14 рублей 3 копейки", Out);
        }
        [TestMethod()]
        public void getresultTest3()
        {
            var n = 1501;
            var Out = Logic.getresult(n);
            Assert.AreEqual("15 рублей 1 копейка", Out);
        }
        [TestMethod()]
        public void getresultTest4()
        {
            var n = 415;
            var Out = Logic.getresult(n);
            Assert.AreEqual("4 рубля 15 копеек", Out);
        }
        [TestMethod()]
        public void getresultTest5()
        {
            var n = 301;
            var Out = Logic.getresult(n);
            Assert.AreEqual("3 рубля 1 копейка", Out);
        }
        [TestMethod()]
        public void getresultTest6()
        {
            var n = 2204;
            var Out = Logic.getresult(n);
            Assert.AreEqual("22 рубля 4 копейки", Out);
        }
        [TestMethod()]
        public void getresultTest7()
        {
            var n = 111;
            var Out = Logic.getresult(n);
            Assert.AreEqual("1 рубль 11 копеек", Out);
        }
        [TestMethod()]
        public void getresultTest8()
        {
            var n = 103;
            var Out = Logic.getresult(n);
            Assert.AreEqual("1 рубль 3 копейки", Out);
        }
        [TestMethod()]
        public void getresultTest9()
        {
            var n = 101;
            var Out = Logic.getresult(n);
            Assert.AreEqual("1 рубль 1 копейка", Out);
        }

    }
}