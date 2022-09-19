using NUnit.Framework;
using System;

namespace myTestProjectForPipeline
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Set up framework");
        }

        [Test]
        public void Test1()
        {
            Assert.Pass("Test is passed");
        }

        [Test]
        public void Test2()
        {
            Assert.Pass("Test is passed");
        }
    }
}