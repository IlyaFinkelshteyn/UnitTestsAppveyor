using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestsAppveyor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace UnitTestsAppveyor.Tests
{
    [TestClass()]
    public class Class1Tests
    {
        [AssemblyInitialize()]
        public static void AssemblyInit(TestContext context)
        {
            Console.WriteLine("AssemblyInit " + context.TestName);
            Thread.Sleep(TimeSpan.FromMinutes(1));
        }
        [TestMethod()]
        public void SumTest()
        {
            Class1 class1 = new Class1();
            Assert.IsTrue(class1.Sum(1, 2) == 3);
        }
        
        [TestMethod()]
        public void BrokenTest()
        {
            Assert.IsTrue(1 == 2);
        }
    }
}
