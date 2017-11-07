using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome.StatusWriters
{
    public interface IStatusWriter
    {
        //this is an Observer Interface that observers status changes
        // there may be many observers as a list
        //this is the method that update the change
        void DeviceStatusChanged(Device device);
    }
}
