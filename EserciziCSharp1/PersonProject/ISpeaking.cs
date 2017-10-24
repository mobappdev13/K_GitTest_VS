using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonProject
{
    public interface ISpeaking 
    {
        string SayHello();
        string SayThanks();

    }
    public class EnglishSpeaking : ISpeaking
    {
        public string SayHello()
        {
            return "Hello!";
        }

        public string SayThanks()
        {
            return "Thank you!";
        }
    }
    public class ItalianSpeaking : ISpeaking
    {
        public string SayHello()
        {
            return "Ciao!";
        }

        public string SayThanks()
        {
            return "Grazie mille!";
        }
    }
    public class GermanSpeaking : ISpeaking
    {
        public string SayHello()
        {
            return "Halo!";
        }

        public string SayThanks()
        {
            return "Dank!";
        }
    }
    public class SpanishSpeaking : ISpeaking
    {
        public string SayHello()
        {
            return "Hola!";
        }

        public string SayThanks()
        {
            return "Gracias!";
        }
    }
}
