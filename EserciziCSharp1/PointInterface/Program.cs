using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInterface
{
    class Program
    {
        //public int result;
        static void Main(string[] args)
        {
            CenterPoint centerPoint = new CenterPoint(3, 0);
           
            int result = centerPoint.Addition(centerPoint.x,centerPoint.y);
            PrintPoint(centerPoint, result);

            result = centerPoint.Subtraction(centerPoint.x, centerPoint.y);
            PrintPoint(centerPoint, result);

            result = centerPoint.Multiplication(centerPoint.x, centerPoint.y);
            PrintPoint(centerPoint, result);
                    
            result = centerPoint.Division(centerPoint.x, centerPoint.y);
            if (result != -99999)
            { 
                    PrintPoint(centerPoint, result);
             }
             else
             {
               Console.WriteLine(" invalid operation ! divide by zero");
             }

            Console.ReadLine();
        }

        private static void PrintPoint(CenterPoint centerPoint, int result)
        {
            Console.WriteLine($" Point:  x = {centerPoint.x} and y = {centerPoint.y}");
            Console.WriteLine($" Result:  = {result}");
        }
    }
}
