using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020_11_30__uzdaviniai_7_is_109_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite pirmo tasko koordinates:");
            int taskas1X = Convert.ToInt32(Ivedimas("x = "));
            int taskas1Y = Convert.ToInt32(Ivedimas("y = "));

            Console.WriteLine("Iveskite antro tasko koordinates:");
            int taskas2X = Convert.ToInt32(Ivedimas("x = "));
            int taskas2Y = Convert.ToInt32(Ivedimas("y = "));

            int vertikaliKrastine = 0;
            int horizontaliKrastine = 0;

            if (taskas1X > taskas2X)
            {
                vertikaliKrastine = taskas1X - taskas2X;
            }
            else
            {
                vertikaliKrastine = taskas2X - taskas1X;
            }

            if (taskas1Y > taskas2Y)
            {
                horizontaliKrastine = taskas1Y - taskas2Y;
            }
            else
            {
                horizontaliKrastine = taskas2Y - taskas1Y;
            }

            Console.WriteLine("Plotas = " + vertikaliKrastine * horizontaliKrastine);
            Console.WriteLine("Perimetras = " + (vertikaliKrastine + horizontaliKrastine) * 2);

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
