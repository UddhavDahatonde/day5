using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5
{
    internal class Class1
    {

        static void Main(string[] args)
        {
            // program for to find the prime number from 1 to 100
            int num = 0,result=0;
            for (int i = 2; i <= 100; ++i)
            {
                num = 0;
               // if (i > 1)
                {
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            num = 1;
                            break;
                        }
                    }
                    if (num == 0)
                    {
                        result++;
                        Console.Write($" {i} ");
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine($"ther are {result} prime number between the range");

        }
    }
}
