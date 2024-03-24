using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            if (numbers.Length == 0) 
                return 0;

            var result = numbers.Where(x => x % 2 == 0).Sum();
            foreach (var num in numbers)
                if (num % 2 != 0)
                    result -= num;

            return result;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int shortest = 0;
            var someStr = new List<string>() { str1, str2, str3, str4 };

            foreach (string str in someStr)
            {
                if (str == "")
                    shortest = 0;
            }

            shortest = someStr.Min(x => x.Length);

            return shortest;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var numList = new List<int>() { number1, number2, number3, number4 };

            return numList.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            var allSides = new List<int>() { sideLength1, sideLength2, sideLength3 };
            foreach (var side in allSides)
                if (side <= 0)
                    return false;

            if (sideLength1 + sideLength2 > sideLength3 && 
                sideLength1 + sideLength3 > sideLength2 && 
                sideLength2 + sideLength3 > sideLength1)
                return true;
            else
                return false;
        }

        public bool IsStringANumber(string input)
        {
            var number = 0;
            var isNumber = int.TryParse(input, out number);

            if (input == null)
                isNumber = false;

            else if (input.Contains('.'))
                isNumber = true;

            return isNumber;

            // it's not an int. It's a string. I need to make this one line.
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var nullItems = objs.Where(item => item == null).ToList().Count;
            var notNull = objs.Where(item => item != null).ToList().Count;

            if (nullItems > notNull)
                return true;
            else if (notNull > nullItems)
                return false;
            else
                return false;
        }

        public double AverageEvens(int[] numbers)
        {

            if (numbers == null || numbers.Length == 0)
                return 0;
            
            var averageOfEvens = numbers.Where(x => x % 2 == 0).DefaultIfEmpty(0).Average();

            return averageOfEvens;
        }

        public int Factorial(int number)
        {
            if (number == 0)
                return 1;
            else if (number < 0)
                throw new ArgumentOutOfRangeException();
            else
                return number * Factorial(number - 1);
        }
    }
}
