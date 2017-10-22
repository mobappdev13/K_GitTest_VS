using Interfaces2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces2
{
    class Program    {
        static void Main(string[] args)
        {
            List<IFlyabile> things = new List<IFlyabile>()
            {
                new Birds(),
                new Planes()
                
            };
           
           
            foreach (IFlyabile item in things)
              {
                //item.Canfly();
               Console.WriteLine("item:  " + item.Canfly().ToString());
            }
            Console.ReadLine();
        }

        
    }

    
}
