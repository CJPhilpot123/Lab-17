using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Prime Finder! \nIn A List of Primes, Which Prime Number are you looking for?");
            int Ask = int.Parse(Console.ReadLine());
            Console.WriteLine(AmazonPrime.Optimus(Ask));
        }
    }
}
