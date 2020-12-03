using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020_12_02__uzdavinys_11_is_109_
{
    class Program
    {
        static void Main(string[] args)
        {
            double atlyginimas = Convert.ToDouble(Ivedimas("Atlyginimas - "));

            Console.WriteLine(atlyginimas * 0.05);
            atlyginimas -= (atlyginimas * 0.05);
            Console.WriteLine(atlyginimas * 0.5);
            Console.WriteLine(atlyginimas * 0.3);
            atlyginimas -= (atlyginimas * 0.8);
            Console.WriteLine(atlyginimas);

            Console.Read();
        }

        private static string Ivedimas(string ivedimoZinute)
        {
            Console.Write(ivedimoZinute);
            string ats = Console.ReadLine();
            return ats;
        }
    }
}
