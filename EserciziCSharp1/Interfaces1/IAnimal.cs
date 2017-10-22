using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces1
{
    interface IAnimal
    {
        string Describe();
        string Name
        {
            get;
            set;
        }
    }
}
