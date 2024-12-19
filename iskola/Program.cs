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

        static int f02(int[] har)
        {
            int szamlalo = 0;
            for (int i = 0; i < har.Length; i++) 
            {
                if(har[i] % 2 == 0)
                {
                    szamlalo++;
                }
            }

            return szamlalo;
        }
    }
}
