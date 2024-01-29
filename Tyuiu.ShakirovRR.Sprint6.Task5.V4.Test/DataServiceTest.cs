using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.ShakirovRR.Sprint6.Task5.V4.Lib;

namespace Tyuiu.ShakirovRR.Sprint6.Task5.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            string path = @"C:\Users\Рамиль\source\repos\Tyuiu.ShakirovRR.Sprint6\Tyuiu.ShakirovRR.Sprint6.Task5.V4\bin\Debug\InPutFileTask5V4.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}