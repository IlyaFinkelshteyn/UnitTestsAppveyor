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

        //public Class1Tests()
        //{
        //    TraceListener[] listeners = {
        //        new TextWriterTraceListener(Console.Out)
        //    };
        //    Debug.Listeners.AddRange(listeners);
        //}

        [AssemblyInitialize()]
        public static void AssemblyInit(TestContext context)
        {
           // Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
            //Trace.WriteLine("AssemblyInit 1 " + context.TestName);
            //Trace.Flush();
            //Thread.Sleep(1);
            Trace.WriteLine("AssemblyInit 2 " + context.TestName);
            //Trace.Flush();
        }


        [TestMethod()]
        public void SumTest()
        {
            Trace.Flush();
            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
            Trace.WriteLine("Sum test 123");
            Trace.Flush();
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

