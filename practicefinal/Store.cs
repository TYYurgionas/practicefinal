using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicefinal
{
    class Store
    {
        string name;
        Item[] items;

        public Store(string name, Item[] item)
        {
            this.name = name;
            this.items = item;

        }
        public void Print()
        {
            System.Console.WriteLine(name);

            foreach (Item i in items)
            {
                i.Print();
            }
        }

    }
}
