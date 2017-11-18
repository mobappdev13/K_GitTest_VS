using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificatoriAccesso
{
    class IndependentClass
    {
        public string myString = "vero";
        private string _id;
        internal int myIntInternal = 325;
        protected int myProtected = 123;
        protected internal int MyProtectedInternal = 455;

        public IndependentClass()
        {
            _id = "idddddddddddddddddddd";
        }
    }
}
