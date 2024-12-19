using System;
using System.Linq;
using System.Collections.Generic;

namespace iskola
{
    internal class Program
    {
        static Random random = new Random();

        static void Main(string[] args)
        {
            f01();

            //Console.ReadKey();
        }

        
        static void f01(int[] har)
        {
            for (int i = 0; i < har.Length; i++)
            {
                har[i] += random.Next(1,51);
            }
        }
    }
}
