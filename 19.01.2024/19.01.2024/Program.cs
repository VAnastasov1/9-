using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _19._01._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kak ti e purvoto ime?");
            var name1 = Console.ReadLine();
            string cocktail ="Vodka " + "Martini " + "Cherry ";
            string a = "uiski";

            Console.WriteLine(name1);
            Console.WriteLine(cocktail);
            Console.WriteLine(a);
            Console.WriteLine(name1 + " shte pie " + cocktail + " i " + a);
            string b = cocktail.Replace("+", " ");
            string cocktail1 = a.Remove(3, 2);
            Console.WriteLine(cocktail1);

            string alpha = cocktail;
            string upperAlpha = alpha.ToUpper();
        }
    }
}
