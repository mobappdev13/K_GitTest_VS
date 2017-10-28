using System;

namespace EserciziCSharp1
{
    public class Person1
    {
        string mNome;
        string mCognome;

        public Person1(string Nome, string Cognome)
        {
            //Imposta le proprietà iniziali della classe.
            if (Nome == string.Empty)
                mNome = "(Nessun nome)";
            else
                mNome = Nome;

            if (Cognome == string.Empty)
                mCognome = "(Nessun cognone)";
            else
                mCognome = Cognome;
        }


        public void StampaMessaggio()
        { }

        private void Appoggio()
        { }

        public string Nome
        {
            get { return mNome; }
            set
            {
                if (value == string.Empty)
                    mNome = "(Nessun nome)";
                else
                    mNome = value;
            }
        }

        public string Cognome
        {
            get { return mCognome; }
            set
            {
                if (value == string.Empty)
                    mCognome = "(Nessun cognome)";
                else
                    mCognome = value;
            }
        }
    }
}
