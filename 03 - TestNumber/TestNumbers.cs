using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            var num3 = int.Parse(Console.ReadLine());

            long sum = 0;
            long count = 0;

            for (int n = num1; n >= 1; n--)
            {
                if (sum > num3)
                {
                    break;
                }
                for (int n2 = 1; n2 <= num2; n2++)
                {
                    sum += (3 * n * n2);
                    count++;
                    if (sum > num3)
                    {
                        Console.WriteLine("{0} combinations", count);
                        Console.WriteLine("Sum: {0} >= {1}", sum, num3);
                        break;
                    }                    
                }
               
            }

            if (sum < num3)
            {
                Console.WriteLine("{0} combinations", count);
                Console.WriteLine("Sum: {0}", sum);
            }          
        }
    }
}
