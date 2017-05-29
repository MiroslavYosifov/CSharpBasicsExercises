using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___Draw_X
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            PrintUpPart(n);
            PrintMidPart(n);

            PrintDownPart(n);
        }

        private static void PrintDownPart(int n)
        {
            for (int i = 0; i < (n - 1) / 2; i++)
            {
                var leftPart = new string(' ', (((n - 1) / 2) - i) - 1);
                Console.Write(leftPart);
                Console.Write("x");
                var mid = new string(' ', 1 + (i * 2));
                Console.Write(mid);
                Console.Write("x");
                Console.WriteLine();
            }
        }

        private static void PrintMidPart(int n)
        {
            Console.Write(new string(' ', (n - 1) / 2));
            Console.Write("x");
            Console.Write(new string(' ', (n - 1) / 2));
            Console.WriteLine();
        }

        private static void PrintUpPart(int n)
        {
            for (int i = 0; i < (n - 1) / 2; i++)
            {
                var leftPart = new string(' ', i);
                Console.Write(leftPart);
                Console.Write("x");
                var mid = new string(' ', ((n - 2) - (i * 2)));
                Console.Write(mid);
                Console.Write("x");
                Console.WriteLine();
            }
        }
    }
}
