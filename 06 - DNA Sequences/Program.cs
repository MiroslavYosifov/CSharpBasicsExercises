using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06___DNA_Sequences
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)

                {
                    for (int z = 1; z <= 4; z++)
                    {
                        if (z + j + i >= num)
                        {
                            var toString = i.ToString() + j.ToString() + z.ToString();
                            toString = toString.Replace('1', 'A');
                            toString = toString.Replace('2', 'C');
                            toString = toString.Replace('3', 'G');
                            toString = toString.Replace('4', 'T');
                            Console.Write("O{0}O ", toString);
                        }
                        else
                        {
                            var toString = i.ToString() + j.ToString() + z.ToString();
                            toString = toString.Replace('1', 'A');
                            toString = toString.Replace('2', 'C');
                            toString = toString.Replace('3', 'G');
                            toString = toString.Replace('4', 'T');
                            Console.Write("X{0}X ", toString);
                        }
                    }
                    Console.WriteLine();
                }
               
            }
        }
    }
}
