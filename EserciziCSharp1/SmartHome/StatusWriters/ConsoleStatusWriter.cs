using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome.StatusWriters
{
    class ConsoleStatusWriter : IStatusWriter
    {
        //this is the concrete class that implements the interface Observer and 
        // its methods for update
        public void DeviceStatusChanged(Device device)
        {
            //only for console
            Console.WriteLine($"*{ device.Room }-{ device.DeviceType }* is { device.Status }*");
        }
    }
}
