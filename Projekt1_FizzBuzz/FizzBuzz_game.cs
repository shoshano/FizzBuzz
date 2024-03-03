using System;

namespace Projekt1_FizzBuzz
{
    internal class FizzBuzz_game
    {
        public int upper_range;     // górny zakres podany przez użytkownika

        // Konstruktor
        public FizzBuzz_game(int ur) 
        {
            upper_range = ur;
            print_results();
        }

        // Sprawdza czy liczba jest podzielna przez 3, 5 lub 15
        public string result(int x)
        {
            string answer = "";
            if (x % 3 == 0)
            {
                answer = answer + "Fizz";            
            }
            if (x % 5 == 0)
            {
                answer = answer + "Buzz";            
            }
            if (answer == "")
            {
                answer = Convert.ToString(x);
            }
            return answer;
        }

        // Wyświetla rezultaty 
        public void print_results() 
        {
            for (int i = 1; i < upper_range + 1; i++)
            {
                string  answer = result(i);
                Console.WriteLine(answer);
            }
        }
    }
}
