using NUnit.Framework;
using ReportPortal.Client.Models;
using ReportPortal.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.Tests
{
    [TestFixture]
    [Description("this is description for Class1")]
    public class Class1
    {
        [Category("T1")]
        [Test]
        public void Test1()
        {
            Bridge.LogMessage(LogLevel.Info, "this is my file {rp#file#dog.png}");
            System.Threading.Thread.Sleep(3000);
        }

        [Test]
        [Description("this is description for Test2")]
        public void Test2()
        {
            System.Threading.Thread.Sleep(5000);
        }
    }
}
