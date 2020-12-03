using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020_12_03__uzdavinys_12_is_109_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite laika kada pradejote daryti namu darbus");
            int pradValanda = Convert.ToInt32(Ivedimas("valanda: "));
            int pradMinute = Convert.ToInt32(Ivedimas("minutes: "));
            TimeSpan x = new TimeSpan(pradValanda, pradMinute, 00);
            Console.WriteLine("iveskite kada baigete daryti namu darbus");
            int pabValanda = Convert.ToInt32(Ivedimas("valanada: "));
            int pabMinute = Convert.ToInt32(Ivedimas("minutes: "));
            TimeSpan y = new TimeSpan(pabValanda, pabMinute, 00);
            Console.WriteLine("Prie namu darbu praleidote {0} valandu, {1} minuciu.", y.Subtract(x).Hours, y.Subtract(x).Minutes);
            Console.ReadLine();
        }

        private static string Ivedimas(string ivedimoZinute)
        {
            Console.WriteLine(ivedimoZinute);
            string ats = Console.ReadLine();
            return ats;
        }
    }
}
