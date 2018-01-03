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

                    var sb = new StringBuilder();
                    sb.AppendLine("\tVendorId: 0x" + description.VendorId.ToString("X"));
                    sb.AppendLine("\tDeviceId: 0x" + description.DeviceId.ToString("X"));
                    sb.AppendLine(description.Description);
                    sb.AppendLine("\tDedicatedVideoMemory: " + description.DedicatedVideoMemory);
                    sb.AppendLine("\tDedicatedSystemMemory: " + description.DedicatedSystemMemory);
                    sb.AppendLine("\tSharedSystemMemory: " + description.SharedSystemMemory);
                    Console.Write(sb);
                }
            }
        }
    }
}
