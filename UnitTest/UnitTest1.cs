using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloProgramme;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("Bonjour et bonne journée", Program.afficherMessage());
        }
    }
}
