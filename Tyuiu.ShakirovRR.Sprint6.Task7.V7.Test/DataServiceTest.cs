using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

using Tyuiu.ShakirovRR.Sprint6.Task7.V7.Lib;

namespace Tyuiu.ShakirovRR.Sprint6.Task7.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            string path = @"C:\Users\Рамиль\source\repos\Tyuiu.ShakirovRR.Sprint6\Tyuiu.ShakirovRR.Sprint6.Task7.V7\bin\Debug\InPutFileTask7V7.csv";
            FileInfo info = new FileInfo(path);
            bool res = info.Exists;
            bool wait = true;
            Assert.AreEqual(wait, res);

        }
    }
}