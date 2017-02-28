﻿using NUnit.Framework;
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
