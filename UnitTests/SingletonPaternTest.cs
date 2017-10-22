﻿using Main.Creational_Patterns.Singleton_Patern;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    [TestClass]
    public class SingletonPaternTest
    {
        [TestMethod]
        public void TestObjectSHouldHaveSameInstance()
        {
            Singleton s1 = Singleton.Instance();
            Singleton s2 = Singleton.Instance();

            Assert.IsTrue(s1 == s2);
        }
    }
}
