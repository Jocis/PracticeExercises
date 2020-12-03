using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020_06_04__uzdaviniai_1_is_109_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite studentu skaiciu");
            int studentai = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("iveskite konspekta sudaranciu lapu skaiciu");
            int lapai = Convert.ToInt32(Console.ReadLine());

            int suma = studentai * lapai;

            Console.WriteLine("{0}", suma);
        }
    }
}
