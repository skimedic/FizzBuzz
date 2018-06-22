using System;
using System.Collections.Generic;

namespace FizzBuzzLibrary
{
    public class FizzBuzz : IFizzBuzz
    {
        private IList<(string word, int divisor)> _words = new List<(string word, int divisor)>();
        public FizzBuzz()
        {
            _words.Add(("Fizz", 3));
            _words.Add(("Buzz", 5));
        }

        public FizzBuzz(params (string word, int divisor)[] wordsAndNumbers)
        {
            foreach (var itm in wordsAndNumbers)
            {
                _words.Add(itm);
            }
        }

        public IEnumerable<string> PrintNumbers(int upperBound = 100)
        {
            if (upperBound <= 0)
            {
                throw new Exception("Upper bound must be greater than 1");
            }

            return FizzBuzzOutput();

            IEnumerable<string> FizzBuzzOutput()
            {
                var l = new List<string>();
                for (int i = 1; i <= upperBound; i++)
                {
                    var output = string.Empty;
                    foreach (var itm in _words)
                    {
                        if (CheckNumberForDivisor(i, itm.divisor))
                        {
                            output += itm.word;
                        }
                    }
                    if (string.IsNullOrEmpty(output))
                    {
                        output = i.ToString();
                    };
                    yield return output;
                }
            }
        }

        public bool CheckNumberForDivisor(int number, int divisor)
        {
            return number != 0 && number % divisor == 0;
        }
    }
}
