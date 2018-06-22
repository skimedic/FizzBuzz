using System.Collections.Generic;

namespace FizzBuzzLibrary
{
    public interface IFizzBuzz
    {
        IEnumerable<string> PrintNumbers(int upperBound = 100);
    }
}