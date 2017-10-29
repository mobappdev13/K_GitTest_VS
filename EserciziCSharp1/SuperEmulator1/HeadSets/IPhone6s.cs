using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperEmulator1.Cameras;

namespace SuperEmulator1
{
     class IPhone6s : HeadSet
    {
        //attenzione
        internal override string Model => "IPhone6S";
        public IPhone6s()
        {
            _frontCamera = new FiveMegapixelsCamera();
            _rearCamera = new EightMegapixelCamera();
        }
    }
}
