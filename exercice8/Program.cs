using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice8
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = 0;
            Console.WriteLine("r = ");
            double.TryParse(Console.ReadLine(), out r);
            double pi = Math.PI;
            double perimetre = 2 * pi * r;
            Console.WriteLine("Le perimetre est égal à " + perimetre);
            double surface = pi * Math.Pow(r, 2);
            Console.WriteLine("La surface du cercle est égal à " + surface);
        }
    }
}
