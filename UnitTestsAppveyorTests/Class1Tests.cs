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


        [AssemblyInitialize()]
        public static void AssemblyInit(TestContext context)
        {
            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
            Trace.WriteLine(String.Format("AssemblyInit started with test {0} at {1}", context.TestName, DateTime.UtcNow));
            Trace.Flush();
            Thread.Sleep(1);
            Trace.WriteLine(String.Format("AssemblyInit finsihed with test {0} at {1}", context.TestName, DateTime.UtcNow));
            Trace.Flush();
        }


        [TestMethod()]
        public void SumTest()
        {
            Debug.Listeners.Add(new TextWriterTraceListener(Console.Out));
            Debug.WriteLine("My line from debug");
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

