using System;

namespace Projekt1_FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj gorny zakres: ");
            int number = Convert.ToInt32(Console.ReadLine());
            FizzBuzz_game mygame = new FizzBuzz_game(number);
        }
    }
}
