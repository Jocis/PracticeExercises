using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020_12_02__uzdavinys_8_is_109_
{
    class Program
    {
        static void Main(string[] args)
        {
            int r = Convert.ToInt32(Ivedimas("Iveskite maziausiojo apskritimo spinduli - "));
            double sum = 0;

            for (int i = 0; i < 3; i++)
            {
                sum = (Math.Pow(r, 2)) * 3.14;
                r *= 2;
                Console.WriteLine(sum);
            }

            Console.ReadLine();
        }

        private static string Ivedimas(string ivedimoZinute)
        {
            Console.Write(ivedimoZinute);
            string ats = Console.ReadLine();
            return ats;
        }
    }
}
