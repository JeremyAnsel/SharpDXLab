using NUnit.Framework;
using SharpDX.Direct3D;
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
                    var level = SharpDX.Direct3D11.Device.GetSupportedFeatureLevel(item);

                    var sb = new StringBuilder();
                    sb.AppendLine(description.Description);
                    sb.AppendLine("\tVendorId: 0x" + description.VendorId.ToString("X"));
                    sb.AppendLine("\tDeviceId: 0x" + description.DeviceId.ToString("X"));
                    sb.AppendLine("\tDedicatedVideoMemory: " + description.DedicatedVideoMemory);
                    sb.AppendLine("\tDedicatedSystemMemory: " + description.DedicatedSystemMemory);
                    sb.AppendLine("\tSharedSystemMemory: " + description.SharedSystemMemory);
                    sb.AppendLine("\tFeatureLevel: " + level);
                    Console.Write(sb);
                }
            }
        }

        [Test]
        public void CreateDeviceTest()
        {
            Adapter adapter;
            using (var factory = new Factory1())
            {
                adapter = factory.GetAdapter(0);
            }

            using (var device = new SharpDX.Direct3D11.Device(adapter, SharpDX.Direct3D11.DeviceCreationFlags.BgraSupport, FeatureLevel.Level_10_0))
            {
                Console.WriteLine(adapter.Description.Description);
                Console.WriteLine(device.FeatureLevel);
            }
        }
    }
}
