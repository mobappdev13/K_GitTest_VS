using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces2
{
    class Birds : IFlyabile
    {
        public string Canfly()
        {
            return ("Birds can fly");
            //throw new NotImplementedException();
        }
    }
}
