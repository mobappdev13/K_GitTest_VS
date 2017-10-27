using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperEmulator1.Cameras;

namespace SuperEmulator1
{
    class GalaxyS : HeadSet
    {
        internal override string Model => "GalaxyS";
        public GalaxyS()
        {
            _frontCamera = new NoCamera();
            _rearCamera = new FiveMegapixelsCamera();
        }
    }
}
