using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020_12_02__uzdavinys_10_is_109_
{
    class Program
    {
        static void Main(string[] args)
        {
            double krastinesIlgis = Convert.ToDouble(Ivedimas("Iveskite skyles krastines ilgi - "));
            double spindulys = Convert.ToDouble(Ivedimas("Iveskite spindulio ilgi - "));

            spindulys *= 2;

            if (spindulys <= krastinesIlgis)
            {
                Console.WriteLine("katinas pralis");
            }
            else
            {
                Console.WriteLine("katinas nepralis");
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
