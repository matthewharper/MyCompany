using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MyCompany.Tests
{
    [TestClass()]
    public class MattControllerTests
    {
        [TestMethod()]
        public void GetTest()
        {
            MattController mc = new MattController();
            Console.WriteLine("matt");
            Console.WriteLine(String.Join("|", mc.Get()));
        }

        [TestMethod()]
        public void GetTest1()
        {
            throw new NotImplementedException();
        }

        [TestMethod()]
        public void PostTest()
        {
            throw new NotImplementedException();
        }

        [TestMethod()]
        public void PutTest()
        {
            throw new NotImplementedException();
        }

        [TestMethod()]
        public void DeleteTest()
        {
            throw new NotImplementedException();
        }
    }
}