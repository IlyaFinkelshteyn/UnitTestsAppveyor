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

        public Class1Tests()
        {
            
        }


        [AssemblyInitialize()]
        public static void AssemblyInit(TestContext context)
        {
            Trace.WriteLine(String.Format("AssemblyInit started with test {0} at {1}", context.TestName, DateTime.UtcNow));
            Trace.WriteLine("Doing something for 30 seconds...");
            Thread.Sleep(TimeSpan.FromSeconds(30));
            Trace.WriteLine(String.Format("AssemblyInit finished with test {0} at {1}", context.TestName, DateTime.UtcNow));
        }


        [TestMethod()]
        public void SumTest()
        {
            Class1 class1 = new Class1();
            Assert.IsTrue(class1.Sum(1, 2) == 3);
        }

        [TestMethod()]
        public void Sum2()
        {
            Class1 class1 = new Class1();
            Assert.IsTrue(class1.Sum(1, 2) == 3);
        }
    }
}

