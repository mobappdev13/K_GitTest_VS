using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces1
{
    class Dog: IAnimal, IComparable, IPrint
    {
        string _name;
        char _sex;
        string _genere;
        public Dog(string name, char sex)
        {
            _name = name;
            _sex = sex;
        }

        public string Name
        {
            get { return _name; }
            set {_name = value; }
        }

        public int CompareTo(object obj)
        {
           if (obj is IAnimal)
             return _name.CompareTo((obj as IAnimal).Name);
            return 0;
           
        }
        
        public string Describe()
        {
            if (_sex == 'M') { _genere = "Maschile"; }
            else { _genere = "Femminile"; }                          
           //
            return "Ciao, sono un cane di genere " + _genere + " e mi chiamano " + _name;
        }

        public string Write()
        {
            throw new NotImplementedException();
        }
    }
}
