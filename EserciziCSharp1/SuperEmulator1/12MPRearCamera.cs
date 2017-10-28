using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperEmulator1
{
    public class _12MPRearCamera : IRearCameraBehavior
    {
        string _fcModel = "12MPRearCamera";
        public string TakePicture()
        {
            throw new NotImplementedException();
        }

        public string FcModel()
        {
            return _fcModel;
        }
    }
}
