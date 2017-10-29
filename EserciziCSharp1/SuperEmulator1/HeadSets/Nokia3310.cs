﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperEmulator1.Cameras;

namespace SuperEmulator1
{
      class Nokia3310 : HeadSet
    {
        internal override string Model => "Nokia 3310";
        public Nokia3310()
        {
            //attenzione
            _frontCamera = new NoCamera();
            _rearCamera = new NoCamera();
        }
    }
}
