using System;

namespace ChallengesWithTestsMark8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Teachers!");

            var test = new ChallengesSet05();

            Console.WriteLine(test.GetNextNumberDivisibleByN(100, 5));

        }
    }
}
