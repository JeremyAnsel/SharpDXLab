using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpDXLab.Tests
{
    [TestFixture]
    class Class1Tests
    {
        [Test]
        public void HelloWorld()
        {
            string hello = Class1.HelloWorld();
            Assert.AreEqual("Hello, World!", hello);
            Console.WriteLine(hello);
        }
    }
}
