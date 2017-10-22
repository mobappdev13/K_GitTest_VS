using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces1
{
    class Program
    {
        //IPrint p;
        static void Main(string[] args)
        {
            List<Dog> dogs = new List<Dog>();
            dogs.Add(new Dog("fufy", 'F'));
            dogs.Add(new Dog("lillih", 'F'));
            dogs.Add(new Dog("susy", 'F'));
            dogs.Add(new Dog("artur", 'M'));
            dogs.Add(new Dog("never", 'M'));

            dogs.Sort();

            Console.WriteLine(); Console.WriteLine();
            foreach (Dog dog in dogs)
            {
                Console.WriteLine(dog.Describe());
            }
            Console.ReadLine();

        }
    }
}
