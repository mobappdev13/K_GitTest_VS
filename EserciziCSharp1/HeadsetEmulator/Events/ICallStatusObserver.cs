using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadsetEmulator.Events
{
    public interface ICallStatusObserver
    {
        //void CallStatusChanged(string number, bool status);
        void CallStatusChanged(bool status);
    }
}
