using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            if (startNumber == 0)
            {
                startNumber++;
            }
            else if (startNumber % n == 0)
            {
                return startNumber + n;
            }

            while (startNumber % n != 0)
            {
                startNumber++;
            }

            return startNumber;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (var company in businesses)
            {
                if (company.TotalRevenue == 0)
                {
                    company.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) { return false; }

            bool isAsc = false;

            var numbersAscending = numbers.OrderBy(x => x).ToList();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbersAscending[i] == numbers[i])
                {
                    isAsc = true;
                }
                else
                {
                    isAsc = false;
                    break;
                }
            }

            return isAsc;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) { return 0; }

            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0 && i != numbers.Length - 1)
                {
                    sum += numbers[i + 1];
                }
            }

            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0)
                return "";

            string sentence = "";
            foreach (var word in words)

                if (word == words[words.Length - 1] && word != " ")
                    sentence += $"{word.Trim()}.";

                else if (word == "" || word == " " || word == "  ")
                    sentence += "";

                else
                    sentence += $"{word.Trim()} ";

            return sentence;
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null || elements.Count == 0)
            { return new double[0]; }

            var getEveryFour = new List<double>();

            for (int i = 3; i < elements.Count; i += 4)
            {
                getEveryFour.Add(elements[i]);
            }
            return getEveryFour.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            if (nums == null || nums.Length == 0 || nums.Length == 1) 
                { return false; }

            int num;
            int num2;
            int sum = 1;

            for (int i = 0; i < nums.Length; i++)
            {
                num = nums[i];

                for (int j = 0; j < nums.Length; j++)
                {
                    num2 = nums[j];

                    if (num + num2 == targetNumber && i != j)
                    {
                        sum = 0;
                        sum = num + num2;
                    }
                }
            }

            return sum == targetNumber;
        }
    }
}
