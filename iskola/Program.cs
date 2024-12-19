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
            int[] asd = { 1, 2, 3 , 4, 5};
            f01(asd);

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
