using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuConsole
{
    public class Lamp
    {
        private bool _isOn;
        public Lamp(string room)
        {
            Room = room;
        }

        public string Room
        {
            get;
            private set;
        }

        public string Status
        {
            get
            {
                if (_isOn)
                {
                    return "on";
                }
                else
                {
                    return "off";
                }
            }//get
            //private set; senza set
            //si poteva fare cosi
            //return _isOn ? "on":"off";
        }//status

        public bool TurnOn()
        {
            _isOn = true;
            return _isOn;
        }
        public bool TurnOff()
        {
            _isOn = false;
            return _isOn;
        }
    }
}
