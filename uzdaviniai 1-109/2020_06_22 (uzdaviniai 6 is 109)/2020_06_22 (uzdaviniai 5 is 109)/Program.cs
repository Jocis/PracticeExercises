using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020_06_22__uzdaviniai_5_is_109_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite kiek keleiviu vaziuoja traukiniu");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite kiek keleiviu vaziuoja ne i Vilniu");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite kiek vagonu yra traukiny");
            int v = Convert.ToInt32(Console.ReadLine());

            int k = 0;

            k = (n - m) / v;

            Console.WriteLine("i Vilniu viename vagone vaziuoja: " + k);
        }
    }
}
