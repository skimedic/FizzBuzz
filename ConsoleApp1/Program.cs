using System;
using FizzBuzzLibrary;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            IFizzBuzz library = new FizzBuzz();
            var list = library.PrintNumbers(100);
            foreach (var i in list)
            {
                Console.WriteLine(i);
            }
            Console.Write("Press enter to end");
            Console.ReadLine();
        }
    }
}
