using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MazurkevichVS.Sprint0.Task2.V0.Lib;

namespace Tyuiu.MazurkevichVS.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void СheckGetMessageValid()
        {
            var name = "Вика";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Вика", res);
        }
    }
}
