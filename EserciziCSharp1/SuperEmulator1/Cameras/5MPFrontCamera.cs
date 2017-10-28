using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperEmulator1
{
    public class _5MFrontCamera : IFrontCameraBehavior
    {
        string _fcModel = "5MFrontCamera";
        public string TakeSelfie()
        {
            throw new NotImplementedException();
        }

        public string FcModel()
        {
            return _fcModel;
        }

       
    }
}
