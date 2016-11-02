using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestsAppveyor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace UnitTestsAppveyor.Tests
{
    [TestClass()]
    public class Class1Tests
    {

        [TestMethod()]
        public void SumTest22()
        {
            Class1 class1 = new Class1();
            Assert.IsTrue(class1.Sum(1, 2) == 3);
        }

        [TestMethod()]
        public void Sum33()
        {
            Class1 class1 = new Class1();
            Assert.IsTrue(class1.Sum(1, 2) == 3);
        }
    }
}

