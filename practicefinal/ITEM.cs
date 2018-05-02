using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicefinal
{
    class Item
    {
        string Name;
        double Price;

        public Item(string Name, double Price)
        {
            this.Name = Name;
            this.Price = Price;
            

        }
        public void Print()
        {
            System.Console.WriteLine(Name + Price);
               
        }
    }

}
