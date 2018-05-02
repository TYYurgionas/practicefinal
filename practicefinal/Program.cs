using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicefinal
{
    class Program
    {
        static void Main(string[] args)
        {
            Item i1 = new Item( "Apple" , 3.99);
            Item i2 = new Item("Granola", 1.99);
            Item i3 = new Item("Zebra", 5.99);


            Item[] items = new Item[3];
            items[0] = i1;
            items[1] = i2;
            items[2] = i3;

            Store s1 = new Store("Banana Stand", items);

            s1.Print();

            System.Console.ReadLine();

        }
    }
}
