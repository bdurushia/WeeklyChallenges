using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            string alphabetLower = "abcdefghijklmnopqrstuvwxyz";
            string alphabetUpper = alphabetLower.ToUpper();

            if (alphabetLower.Contains(c) || alphabetUpper.Contains(c))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CountOfElementsIsEven(string[] vals)
        {

            return vals.Length % 2 == 0 ? true : false;
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0 ? true : false;
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0 ? true : false;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            else if (numbers.Count() > 0)
            {
                return numbers.Min() + numbers.Max();
            }
            else
            {
                return 0;
            }

        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return str1.Length < str2.Length ? str1.Length : str2.Length;
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
            { 
                return 0; 
            }
            else
            {
                int sum = 0;

                for (int i = 0; i < numbers.Length; i++)
                {
                    sum += numbers[i];
                }
                return sum;
            }
            
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            { 
                return 0; 
            }
            else
            {
                int sum = 0;
                foreach (int num in numbers)
                {
                    if (num % 2 == 0)
                    {
                        sum += num;
                    }
                }
                return sum;
            }
            
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            { 
                return false; 
            }

            int sum = 0;

            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum % 2 != 0 ? true : false;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number <= 1)
            {
                return 0;
            }
            else
            {
                long countOdds = number / 2;

                return int.Parse(countOdds.ToString());
            }
        }
    }
}
