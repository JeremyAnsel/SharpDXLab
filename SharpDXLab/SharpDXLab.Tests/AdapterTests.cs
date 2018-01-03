using NUnit.Framework;
using SharpDX.DXGI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpDXLab.Tests
{
    [TestFixture]
    class AdapterTests
    {
        [Test]
        public void AdapterTest()
        {
            using (var factory = new Factory1())
            {
                foreach (var item in factory.Adapters)
                {
                    var description = item.Description;
                    Console.WriteLine(description.Description);
                }
            }
        }
    }
}
