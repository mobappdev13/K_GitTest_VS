using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificatoriAccesso
{
    class PrivateClass
    {
        //only protected field can be used on derivated class 
        // this can be accesed to another place
        private string _cognome;
        private int _eta;
        private int _id;
        private string _nome;
        private string _statoCivile;

        public string publicString = "PUBLIC";
        private string privateString = "PRIVATE";
        internal string internalString = " INTERNAL";
        protected string protectedString = "PROTECTED";
        protected internal string protectedInternal = "PROTECTED INTERNAL";

        public PrivateClass()
        {
            _cognome = "unknown";
        }
        public PrivateClass(int id, string nome, string cognome, int eta, string statoCivile)
        {
            _id = id;
            _nome = nome;
            _cognome = cognome; //+ internalString + privateString//;
            _eta = eta;
            _statoCivile = statoCivile;
        }
        //public string NameItem
        //{
        //    get { return _nameItem; }
        //    private set { _nameItem = value; }
        //}


        public int Id { get { return _id; } set { _id = value; } }
        public string Nome { get { return _nome; } set { _nome = value; } }
        public string Cognome { get { return _cognome; } private set { _cognome = value; } }
        public int Eta { get { return _eta; } private set { _eta = value; } }

        public string StatoCivile { get { return _statoCivile; } set { _statoCivile = value; } }

       
        public string SetNameClass()
        {
            return "Private Class";
        }

        public string ReturnIternal()
        {
            return internalString;
        }

        public string myPrint()
        {
            return "";
           // return ($"{publicString}* {privateString}**{internalString}***{protectedString}***{protectedInternal}");
        }
    }
}
