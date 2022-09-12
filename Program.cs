using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InicijalnoPonavljanjeZad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string x;

            Console.WriteLine("Unesite rečenicu: ");
            x = Console.ReadLine();

            x = x.Replace(" ", "_");

            Console.WriteLine("Promjena: " + x);

            Console.ReadKey();
        }
    }
}
