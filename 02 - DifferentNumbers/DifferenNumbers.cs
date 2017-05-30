using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());

                         
                for (int n = num1; n < num2; n++)
                {
                    for (int n2 = num1; n2 < num2; n2++)
                    {
                        for (int n3 = num1; n3 < num2; n3++)
                        {
                            for (int n4 = num1; n4 < num2; n4++)
                            {
                                for (int n5 = num1; n5 <= num2; n5++)
                                {
                                    if (num1 <= n && n < n2 && n2 < n3 && n3 < n4 && n4 < n5 && n5 <= num2)
                                    {
                                        
                                    }
                                }
                            }
                        }
                    }
                }
           
         
        }
    }
}
