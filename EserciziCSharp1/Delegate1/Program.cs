using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate1
{

    class Program
    {
        delegate int NumberChanger(int n);
        static int num = 10;
       
        static void Main(string[] args)
        {
            Console.WriteLine("Value of initial num: {0}", getNum());
            Console.ReadLine();
            //create delegate instances
            NumberChanger numberCharger1 = new NumberChanger(AddNum);
            NumberChanger numberCharger2 = new NumberChanger(MultiplyNum);

            //calling the methods using the delegate objects
            numberCharger1(25);
            Console.WriteLine("Value of Num: {0}", getNum());
            numberCharger2(5);
            Console.WriteLine("Value of Num: {0}", getNum());
            Console.ReadKey();
        }
        

        public static int AddNum(int p)
        {
            num += p;
            return num;
        }

        public static int MultiplyNum(int q)
        {
            num *= q;
            return num;
        }

        public static int getNum()
        {
            return num;
        }

    }
}

