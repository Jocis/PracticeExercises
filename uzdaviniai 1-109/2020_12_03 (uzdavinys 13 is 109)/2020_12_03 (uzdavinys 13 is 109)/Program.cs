using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020_12_03__uzdavinys_13_is_109_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("irasykite lazdeliu ilgius metrais:");
            double lazdele1 = Convert.ToDouble(Ivedimas("lazdele 1 - "));
            double lazdele2 = Convert.ToDouble(Ivedimas("lazdele 2 - "));

            string ats = "abeju lazdeliu ilgis colineje sistemoje:\n";
            double sum = lazdele1 + lazdele2;
            double colis = 0.0254;
            double peda = colis * 12;
            double jardas = peda * 3;

            if (sum > jardas)
            {
                ats += (sum / jardas).ToString() + " jardu\n";
            }
            if (sum > peda)
            {
                ats += (sum / peda).ToString() + " pedu\n";
            }
            ats += (sum / colis).ToString() + " coliu";

            Console.WriteLine(ats);
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
