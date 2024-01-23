
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._01._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string listOfBeers = "Amstel, Zagorka, Tuborg, Becks.";
            string[] beers = listOfBeers.Split(' ', ',', '.');
            Console.WriteLine("Available beers are:");
            foreach (string beer in beers)
                Console.WriteLine(beer);

            string listOfBeers1 = "Az,Valenin,obi4am,da,piq,voda";
            string[] beers1 = listOfBeers1.Split(' ', ',', '.');
            Console.WriteLine("Завърших защото:");
            foreach (string Az in beers1)
                Console.WriteLine(Az);

            string replaced = listOfBeers.Replace(",", " ");
            Console.WriteLine(replaced);

            string novo = replaced.Remove(6, 10);
            Console.WriteLine(novo);
            string lowerAlpha = novo.ToLower();
            Console.WriteLine(lowerAlpha);
            string upperAlpha = listOfBeers1.ToUpper();
            Console.WriteLine(upperAlpha);

            string novo1 = listOfBeers1.Replace(",", " ");

            string nov = listOfBeers1.Remove(25,4);
            Console.WriteLine(nov);
            
            
        }
    }
}
