using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab1_forms;
namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod()]
        public void getresultTest1()
        {
            var n = 1215;
            var Out = Logic.getresult(n);
            Assert.AreEqual("12 ������ 15 ������", Out);
        }
        [TestMethod()]
        public void getresultTest2()
        {
            var n = 1403;
            var Out = Logic.getresult(n);
            Assert.AreEqual("14 ������ 3 �������", Out);
        }
        [TestMethod()]
        public void getresultTest3()
        {
            var n = 1501;
            var Out = Logic.getresult(n);
            Assert.AreEqual("15 ������ 1 �������", Out);
        }
        [TestMethod()]
        public void getresultTest4()
        {
            var n = 415;
            var Out = Logic.getresult(n);
            Assert.AreEqual("4 ����� 15 ������", Out);
        }
        [TestMethod()]
        public void getresultTest5()
        {
            var n = 301;
            var Out = Logic.getresult(n);
            Assert.AreEqual("3 ����� 1 �������", Out);
        }
        [TestMethod()]
        public void getresultTest6()
        {
            var n = 2204;
            var Out = Logic.getresult(n);
            Assert.AreEqual("22 ����� 4 �������", Out);
        }
        [TestMethod()]
        public void getresultTest7()
        {
            var n = 111;
            var Out = Logic.getresult(n);
            Assert.AreEqual("1 ����� 11 ������", Out);
        }
        [TestMethod()]
        public void getresultTest8()
        {
            var n = 103;
            var Out = Logic.getresult(n);
            Assert.AreEqual("1 ����� 3 �������", Out);
        }
        [TestMethod()]
        public void getresultTest9()
        {
            var n = 101;
            var Out = Logic.getresult(n);
            Assert.AreEqual("1 ����� 1 �������", Out);
        }
}
}
