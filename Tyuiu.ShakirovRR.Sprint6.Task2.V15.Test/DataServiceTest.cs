﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShakirovRR.Sprint6.Task2.V15.Lib;

namespace Tyuiu.ShakirovRR.Sprint6.Task2.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestGetMassFunction()
        {
            DataService ds = new DataService();
            double[] wait = { 15.48, 1, -13.06 };
            CollectionAssert.AreEqual(wait, ds.GetMassFunction(-1, 1));
        }
    }
}