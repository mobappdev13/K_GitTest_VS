using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperEmulator1
{
    internal class ActionResult
    {
        public string _message { get; private set; }
        public bool _success { get; private set; }

        public ActionResult(string message, bool success)
        {
            _message = message;
            _success = success;
        }
    }
}
