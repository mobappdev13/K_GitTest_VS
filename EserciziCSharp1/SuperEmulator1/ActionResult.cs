using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperEmulator1
{
    internal class ActionResult
    {
        public string Message { get; private set; }
        public bool Success { get; private set; }

        public ActionResult(bool success, string message)
        {
            Success = success;
            Message = message;
        }
        //attenzione inner costruttire
        public ActionResult(bool success) : this(success, string.Empty)
        {
        }
    }
}
