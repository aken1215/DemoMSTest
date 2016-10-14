using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestMsBuild;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMsBuild.Tests
{
    [TestClass()]
    public class CalculateTests
    {
        [TestMethod()]
        public void PlusTest()
        {
            var target = new Calculate();
            var first = 1;
            var second = 2;
            var expected = 3;

            var actual = target.Plus(first, second);

            Assert.AreEqual(expected, actual);



        }
    }
}