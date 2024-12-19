using System;
using System.Linq;
using System.Collections.Generic;
using System.Net;

namespace iskola
{
    internal class Program
    {
        static Random random = new Random();

        static void Main(string[] args)
        {
            

            Console.ReadKey();
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

        static double f03(int[] har) 
        {
            double atl = 0;
            for(int i = 0;i < har.Length; i++)
            {
                atl += har[i];
            }
            atl = atl / har.Length;

            return atl;
        }

        static int[] f04(int[] har)
        {
            int[] paratlanok = new int[10];

            for(int i = 0; i < har.Length; i++)
            {
                if (har[i] % 2 == 0)
                {
                    har[i]++;
                }
                paratlanok[i] += har[i];
            }

            return paratlanok;
        }

        static void f05(int[] har)
        {
            Console.WriteLine($"Ennyi darab PÁROS szám van a tömbben: {f02(har)}");
            Console.WriteLine($"A tömb elemeinek átlaga: {f03(har)}");
            Console.WriteLine("A tömbből alkotott páratlan számok: ");

            foreach(int i in f04(har))
            {
                Console.Write(i + "; ");
            }
            Console.WriteLine();
        }
    }
}
