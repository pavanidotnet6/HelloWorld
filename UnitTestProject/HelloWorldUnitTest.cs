using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shared.UnitOfWork;
using HW.UnitOfWork;
using Shared.Service;
using Service.HW;

namespace UnitTestProject
{
    [TestClass]
    public class HelloWorldUnitTest
    {
        /// <summary>
        /// This function would make call to console app n return output string
        /// </summary>
        [TestMethod]
        public void HelloWorldTestMethod()
        {
            string inputText = "input";
            string outPutText = "Hello World!";
            var result = ConsoleApplication.Program.HelloWorldFunction(inputText);
            Assert.AreEqual(result, outPutText);
        }
    }
}
