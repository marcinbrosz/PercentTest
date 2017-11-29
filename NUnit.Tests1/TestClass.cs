using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit.Tests1
{
    [TestFixture]
    public class TestClass
    {

        [Test]
        public void Test1()
        {
            Assert.AreEqual(22, PercentTest.Library.PercentTest.Evaporator(10, 10, 10));
        }
        [Test]
        public void Test2()
        {
            Assert.AreEqual(29, PercentTest.Library.PercentTest.Evaporator(10, 10, 5));
        }
        [Test]
        public void Test3()
        {
            Assert.AreEqual(59, PercentTest.Library.PercentTest.Evaporator(100, 5, 5));
        }
        [Test]
        public void Test4()
        {
            Assert.AreEqual(37, PercentTest.Library.PercentTest.Evaporator(50, 12, 1));
        }
        [Test]
        public void Test5()
        {
            Assert.AreEqual(31, PercentTest.Library.PercentTest.Evaporator(47.5, 8, 8));
        }
        [Test]
        public void Test6()
        {
            Assert.AreEqual(459, PercentTest.Library.PercentTest.Evaporator(100, 1, 1));
        }
        [Test]
        public void Test7()
        {
            Assert.AreEqual(459, PercentTest.Library.PercentTest.Evaporator(10, 1, 1));
        }
        [Test]
        public void Test8()
        {
            Assert.AreEqual(299, PercentTest.Library.PercentTest.Evaporator(100, 1, 5));
        }
    }
}
