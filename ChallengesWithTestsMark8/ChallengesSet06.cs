using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null) return false;
            if (words.Any(x => string.IsNullOrEmpty(x))) return false;

            bool containsWord = false;

            if (ignoreCase) // if it is NOT case sensitive
            {
                if (words.Any(x => x.ToLower() == word.ToLower())) { containsWord = true; }
            }
            else // if it is case sensitive
            {
                if (words.Any(x => x == word)) { containsWord = true; }
            }

            return containsWord;
        }

        public bool IsPrimeNumber(int num)
        {
            int tempNum = 0;

            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    tempNum++;
                }
            }

            return num <= 0 || num == 1 ? false : tempNum == 0 ? true : false;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            return str.IndexOf(str.Distinct().Reverse().FirstOrDefault(s => str.Count(x => x.Equals(s)) == 1));
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int currentCount = 1;
            int maxCount = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {

                if (numbers[i] == numbers[i + 1])
                {
                    currentCount++;
                    if (maxCount < currentCount)
                    {
                        maxCount = currentCount;
                    }
                }
                else
                {
                    currentCount = 1;
                }
            }

            return maxCount;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if (elements == null || elements.Count == 0 || n <= 0)
            {
                return new double[0];
            }
            var nthElementList = new List<double>();

            for (int i = n - 1; i < elements.Count; i += n)
            {
                nthElementList.Add(elements[i]);
            }

            return nthElementList.ToArray();
        }
    }
}
