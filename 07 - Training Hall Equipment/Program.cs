using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07___Training_Hall_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            var buget = double.Parse(Console.ReadLine());
            var totalSumItems = 0.0;

            var numberOfItems = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfItems; i++)
            {
                var nameOfItem = Console.ReadLine();
                var priceOfItem = double.Parse(Console.ReadLine());
                var countOfItems = int.Parse(Console.ReadLine());

                if(countOfItems >1)
                {
                    nameOfItem = PrintItemInPlural(nameOfItem, countOfItems);
                }
                else
                {
                    Console.WriteLine($"Adding {countOfItems} {nameOfItem} to cart.");
                }
                totalSumItems += (priceOfItem * countOfItems);
                
            }
          

            Console.WriteLine($"Subtotal: ${totalSumItems:f2}");


            if (buget >= totalSumItems)
            {
                Console.WriteLine($"Money left: ${Math.Abs(buget - totalSumItems):f2}");
            }
            else
            {
                Console.WriteLine($"Not enough. We need ${Math.Abs(buget - totalSumItems):f2} more.");
            }
           

        }

        private static string PrintItemInPlural(string nameOfItem, int countOfItems)
        {
            if (nameOfItem.EndsWith("o") || nameOfItem.EndsWith("ch") || nameOfItem.EndsWith("s")
       || nameOfItem.EndsWith("sh") || nameOfItem.EndsWith("x") || nameOfItem.EndsWith("z"))
            {
                nameOfItem = nameOfItem + "es";
                Console.WriteLine($"Adding {countOfItems} {nameOfItem} to cart.");
            }
            else if (nameOfItem.EndsWith("y"))
            {
                nameOfItem = nameOfItem.Remove(nameOfItem.Length - 1);
                nameOfItem = nameOfItem + "ies";
                Console.WriteLine($"Adding {countOfItems} {nameOfItem} to cart.");
            }
            else
            {
                nameOfItem = nameOfItem + "s";
                Console.WriteLine($"Adding {countOfItems} {nameOfItem} to cart.");
            }

            return nameOfItem;
        }
    }
}
