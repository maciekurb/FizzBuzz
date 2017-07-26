using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class FizzBuzz
    {
        private const int Fizzing = 3;
        private const int Buzzing = 5;

        public bool IsFizz(int number)
        {
            return number % Fizzing == 0;
        }
        public bool IsBuzz(int number)
        {
            return number % Buzzing == 0;
        }
        public bool IsFizzBuzz(int number)
        {            
            //return IsFizz(number) && IsBuzz(number); - can't decide which option is more efficient 
            return number % (Fizzing * Buzzing) == 0;
        }

        public string Go(int number)
        {
            if (IsFizzBuzz(number)) return "FizzBuzz";
            if (IsBuzz(number)) return "Buzz";
            if (IsFizz(number)) return "Fizz";
            return number.ToString();
        }

        public string[] GetSequence(int range)
        {
            var sequence = new List<string>();
            for (int i = 1; i <= range; i++)
            {
                sequence.Add(Go(i));
            }
            return sequence.ToArray();
        }
    }
}
