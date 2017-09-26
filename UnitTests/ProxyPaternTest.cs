﻿using Main.Creational_Patterns.Builder_Patern;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Main.Structural_Patterns.Proxy_Patern;

namespace UnitTests
{
    [TestClass]
    public class ProxyPaternTest
    {
        [TestMethod]
        public void TestShowImageShouldBeTrue()
        {
            IImage imageProxy = new HighResImageProxy("path");
            Assert.IsTrue(imageProxy.ShowImage());
        }

        [TestMethod]
        public void TestCallingShowImageTwiceExpensiveResourceShouldBeCalledOnce()
        {
            var imageProxy = new HighResImageProxy("path");
            imageProxy.ShowImage();
            imageProxy.ShowImage();

            Assert.IsTrue(imageProxy.Counter == 1);
        }
    }
}