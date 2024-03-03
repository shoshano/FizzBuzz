using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1_FizzBuzz
{
    internal class FizzBuzz_game
    {
        public int upper_range;
        public FizzBuzz_game(int ur) 
        {
            upper_range = ur;
            print_results();
        }

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
