using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EserciziCSharp1
{
    class Person
    {
        //  Person p = new Person(1, "Margherita","Rossa", 19/06/1961,"",true);
        //variabili private
        private int _id;
        private string _name;
        private string _lastname;
        DateTime _dateofBirth;
        private string _nationality;
        private bool _beEnrrolled;
        private double _salario;
       

    //construttore
    public Person(int id, string name, string lastname, DateTime dateofBirth, string nationality, bool beEnrrolled, double salario)
        {
            Id = id;
            Name = name;
            Lastname = lastname;
            DateofBirth = dateofBirth;
            Nationality = nationality;
            BeEnrrolled = beEnrrolled;
            Salario = salario;
        }

        //propietà getters and setters 
        public int Id
        {
            //valori in input
            get { return _id; }
            private set
            {
                if (value == 0)
                    _id = -1; // o 0 ?
                else
                    _id = value;

            }
        }

        public string Name
        {
            get { return _name; }
            //private set non riece ad essere modificato
            private set
            {

                if (_name == string.Empty)
                    _name = "****no name****";
                else
                    _name = value;

            }
        }

        public string Lastname
        {
            get { return _lastname; }
            private set
            {
                if (value == string.Empty)
                    _lastname = "****no lastname****";
                else
                    _lastname = value;
            }
        }


        public DateTime DateofBirth
        {
            get { return _dateofBirth; }
            private set
            {
                if (value == null)
                    value = DateTime.Now;
                else
                    _dateofBirth = value;
            }
        }

        public string Nationality
        {
            get { return _nationality; }
            private set

            {
                if (value == string.Empty)
                    _nationality = "no nationality";
                else
                    _nationality = value;
            }
        }

        public bool BeEnrrolled
        {
            get { return _beEnrrolled; }
            private set
            {
                if (value == false)
                    _beEnrrolled = false;
                else
                    _beEnrrolled = value;
            }
        }


        public double Salario
        {
            get { return _salario; }
            set
            {
                if (value <= 0)
                    _salario = 0;
                else
                    _salario = value;
            }
        }

        //metodi

       public string Speech(string nationality)
        {
            if (nationality == "Italiana")
            {
                return " parla italaino ciao mondo ";
            }
            else
            {
                return " speak english hello world";
            }
        }

        public double CalcolateTax (double salario)
        {

            return salario * (1 - 0.43);
        }

        public int CalcolateAge (DateTime dateofBirth)
        {
            // Save today's date.
            var today = DateTime.Today;
            // Calculate the age.
            var age = today.Year - dateofBirth.Year;
            // Go back to the year the person was born in case of a leap year
            if (dateofBirth > today.AddYears(-age)) age--;
            return age;
        }
    }
}//

