using System;
using System.Linq;

namespace PersonProject
{
    public enum PersonState { Inghilterra,Italia,Spagna,Germania }
    public class Person 
    {
        private string _name;
        private string _surname;

        public Person(int id, string name, string surname, DateTime dateOfBirth,PersonState nationality)
        {
            Id = id;
            Name = name;
            Surname = surname;
            DateOfBirth = dateOfBirth;
            Nationality = nationality;
            Speaking = GetSpeakingLanguage(nationality);
        }

        private ISpeaking GetSpeakingLanguage(PersonState nationality)
        {
            switch (nationality)
            {
                case PersonState.Inghilterra:
                    return new EnglishSpeaking();
                case PersonState.Italia:
                    return new ItalianSpeaking();
                case PersonState.Spagna:
                    return new SpanishSpeaking();
                case PersonState.Germania:
                    return new GermanSpeaking();
                default: throw new NotImplementedException();
            }
        }

        public int Id { get; private set; }

        public string Name
        {
            get { return _name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Name must have a value");
                if (value.Length > 35)
                    throw new ArgumentException("Name cannot be longer than 35 characters");
                if (value.Any(c => char.IsDigit(c)))
                    throw new ArgumentException("Name cannot contain numbers");
                _name = value;
            }
        }
        public string Surname {
            get { return _surname; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Surname must have a value");
                if (value.Length > 35)
                    throw new ArgumentException("Surname cannot be longer than 35 characters");
                if (value.Any(c => char.IsDigit(c)))
                    throw new ArgumentException("Surname cannot contain numbers");
                _surname = value;
            }
        }
        public DateTime DateOfBirth { get; private set; }
        public PersonState Nationality { get; set; }
        public ISpeaking Speaking { get; set; }

        public override string ToString()
        {
            return $"[{Id}] - {Name} {Surname} - DOB: {DateOfBirth.ToShortDateString()}";
        }

    }
}