using System;
using System.Linq;
namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            // throw new NotImplementedException();
            int result = 0;
            foreach (var i in numbers) {
                if (i % 2 == 0) result += i;
                else result -= i;
            }

            return result;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            String[] strings = { str1, str2, str3, str4 };
            var stringsSorted = (strings.OrderBy(s => s.Length));
            String[] stringsSortedString = stringsSorted.ToArray();
            return stringsSortedString[0].Length;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int[] numbers = { number1, number2, number3, number4 };
            var numbersSorted = numbers.OrderBy(n => n);
            int[] numbersSortedNumbers = numbersSorted.ToArray();
            return numbersSortedNumbers[0];
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 + sideLength2 > sideLength3) return true;
            if (sideLength1 + sideLength3 > sideLength2) return true;
            if (sideLength2 + sideLength3 > sideLength1) return true;
            return false;
        }

        public bool IsStringANumber(string input)
        {
            if (int.TryParse(input, out var number)) return true;
            return false;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int majority = objs.Length / 2 + 1;
            int count = 0;
            foreach(var o in objs) {
                if (o == null) count++;
            }
            if (count > majority) return true;
            return false;
        }

        public double AverageEvens(int[] numbers)
        {
            double averageOfEvens = numbers.Where(n => (n % 2 == 0)).Average();
            return averageOfEvens;
        }

        public int Factorial(int number)
        {
            int result = 1;
            for (int downCount = number; downCount >= 1; downCount--) result *= downCount;
            return result;
        }
    }
}
