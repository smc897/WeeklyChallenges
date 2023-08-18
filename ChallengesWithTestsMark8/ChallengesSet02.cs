using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        //is c a letter?
        public bool CharacterIsALetter(char c)
        {
            if (Char.IsLetter(c)) return true;
            else return false;
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2 == 1) return false;
            else return true;
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 1) return false;
            else return true;
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 == 1) return true;
            else return false;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            numbers.OrderBy(num=>num);
            return numbers.ElementAt(0) + numbers.ElementAt(numbers.Count() - 1);
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length < str2.Length) return str1.Length;
            else return str2.Length;
        }

        public int Sum(int[] numbers)
        {
            int sum = 0;
            for (int index = 0; index < numbers.Length; index++) sum += numbers[index];
            return sum;
        }

        public int SumEvens(int[] numbers)
        {
            int sum = 0;
            for (int index = 0; index < numbers.Length; index+=2) sum += numbers[index];
            return sum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            int sum = 0;
            for (int index = 0; index < numbers.Count; index++) sum += numbers[index];
            if (sum % 2 == 1) return true;
            else return false;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            long count = 0;
            for (int index = 1; index < number; index++) count++;
            return count;
        }
    }
}
