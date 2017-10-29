using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proprieta
{
    public class Program
    {
        static void Main(string[] args)
        {
            var item = new SaleItem(" blusa", 22.78);
            Console.WriteLine($"sold an {item.NameItem } for this price {item.PriceItem} Euro");
            Console.ReadLine();
        }
    }
}
