using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX21_Getters_and_Setters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Movie movies1 = new Movie("Titanic", "Jim", "PG-13");
            Movie movies2 = new Movie("Unreleased", "Evans", "PG");

            Console.WriteLine(movies1.Rating);
            Console.ReadLine();
        }
    }
}
