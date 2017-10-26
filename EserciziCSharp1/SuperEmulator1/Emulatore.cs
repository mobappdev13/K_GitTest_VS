using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperEmulator1
{
    public class Emulator
    {
        public string _isCallStart;

       
        public HeadSet SelectedModel { get; set; }
        public string CallStatus
        {
            get { return _isCallStart ? "si" : "no"; }
            //set;}
        }

        public bool Call(string phoneNumber)
        {
            //attenzione gli stattin una classe call
            return false;
        }
        
        public bool HangUpCall(string phoneNumber)
        {
            return false;
        }

        private bool IsModelSelected()
        {
            return false;
        }

        

    }
}
