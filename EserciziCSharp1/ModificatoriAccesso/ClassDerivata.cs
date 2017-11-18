using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificatoriAccesso
{
    class DerivatedClass : PrivateClass
    {
        private string _name;

        public DerivatedClass()
        {
            _name = "in classe derivata";
        }

        public string Name { get { return _name; } private set{_name = value; } }

        public string Method1()
        {
            return "";
            //return " sono un metodo publico della classe";
        }

        public string MembersVarBaseClass()
        {

            return ($"dalla derivata { publicString} { internalString} {protectedInternal} {protectedString}");
        }
    }
}
