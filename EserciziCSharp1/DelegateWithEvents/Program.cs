using System;

namespace SampleApp
{
    public delegate string MyDelegate(string str);

    class Events
    {
        event MyDelegate _MyEvent;

        public Events()
        {
            _MyEvent += new MyDelegate(this.WelcomeUser);
        }

        public string WelcomeUser(string username)
        {
            return "Hi, Welcome " + username;
        }

        static void Main(string[] args)
        {
            Events greet = new Events();
            
            string result = greet._MyEvent("user Carmen ");
            Console.WriteLine(result);
            Console.ReadLine();
        }

    }
}