using System;
using System.Collections.Generic;

namespace FibonacciSeq
{
    public class Fibo
    {

        static void Main(string[] args)
            {
                int n1 = 0;
                int n2 = 1;
                int r  ;
                List<int> fibonoList = new List<int>();
                for (int i = 0; i < 5; i++)
                 {
                     fibonoList.Add(n2);
                     Console.WriteLine(n2);
                     r = n2;
                     n2 = n1 + n2;
                     n1 = r;
                     
                }
                Console.WriteLine("Enter a number");
                int number = int.Parse(Console.ReadLine());
                if (fibonoList.Contains(number))
                {
                    Console.WriteLine("IsFibo");
                }
                else
                {
                    Console.WriteLine("IsNotFibo");
                }
                Console.ReadKey();
            }
        }
    }
