using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020_06_24__uzdaviniai_5_is_109_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Irasykite kiek knygu yra perskaitoma per menesi");
            int v = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Irasykite kiek per metus apsilanko lankytoju");
            int n = Convert.ToInt32(Console.ReadLine());

            int k = 0;
            int a = 1;

            a = v * 12;
            k = a / n;

            Console.WriteLine("per metus vienas lankytojas perskaito {0} knygu", k);
        }
    }
}
