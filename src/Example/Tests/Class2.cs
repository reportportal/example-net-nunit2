using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.Tests
{
    [Category("Category 1"), Category("Category 2")]
    [TestFixture]
    public class Class2
    {
        [Test]
        public void Test1([Range(1, 30, 1)] int i)
        {
            for (int j = 0; j < 20; j++)
            {
                Console.WriteLine("Test 1 out " + j);
            }
        }

        [Test]
        public void Test2()
        {
            System.Threading.Thread.Sleep(6000);
        }

        [Test]
        public void Test3()
        {
            System.Threading.Thread.Sleep(7000);
            Assert.Fail("test failed.");
        }
    }
}
