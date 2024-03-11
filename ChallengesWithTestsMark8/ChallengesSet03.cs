using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            var containsFalse = vals.Where(val => val == true ? false : true);
            return containsFalse.Any();
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
                return false;
            var sum = numbers.Where(num => num % 2 != 0).Sum();
            return sum % 2 != 0 ? true : false;
            
            
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            if (password == null) return false;

            var trueDigit = password.Any(char.IsDigit);
            var trueUpper = password.Any(char.IsUpper);
            var trueLower = password.Any(char.IsLower);

            if (trueDigit && trueUpper && trueLower)
                return true;
               
            return false;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val.First();
        }

        public char GetLastLetterOfString(string val)
        {
            return val.Last();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            return dividend == 0 || divisor == 0 ? 0 : dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums.Last() - nums.First();
        }

        public int[] GetOddsBelow100()
        {
            List<int> odds = new List<int>();
            for (int i = 1; i <= 99; i+= 2 )
            {
                odds.Add(i);
            }
            return odds.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
