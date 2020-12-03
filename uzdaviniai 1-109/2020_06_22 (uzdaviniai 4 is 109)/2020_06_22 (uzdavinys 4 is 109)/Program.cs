using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020_06_22__uzdavinys_4_is_109_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite kiek valandu dabar povidurnakcio");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("dabar kiek minuciu");
            int c = Convert.ToInt32(Console.ReadLine());

            int b = a * 60;
            int m = 1;
            int suma = 0;

            for (int i = 1; i <= b; i++)
            {
                m = i / i;
                suma += m;              
            }
            Console.WriteLine("minuciu: " + (suma + c));
            Console.WriteLine("sekundziu: " + (suma + c) * 60);
        }
    }
}
