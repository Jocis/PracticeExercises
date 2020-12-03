using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020_06_04__uzdavinai_2_is_109_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("irasykite vieno kvadratinio metro plyteliu kaina");
            double kaina = Convert.ToDouble(Console.ReadLine());

            int ilgis = 4;
            int plotis = 3; // abu dydziai yra zinomi 
            var papildomosPlyteles = 1.05; // 5% daugiau plyteliu

            var kambarioPlotas = ilgis * plotis * papildomosPlyteles; // plota padauginu kad plyteliu gautusi 5% daugiau
            var suma = kambarioPlotas * kaina;

            Console.WriteLine("{0} * {1} = {2}", kambarioPlotas, kaina, suma);
        }
    }
}
