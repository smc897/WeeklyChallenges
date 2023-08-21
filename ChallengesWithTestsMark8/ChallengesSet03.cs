using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            //throw new NotImplementedException();
            foreach (bool b in vals) { if (!b) return true; }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            //throw new NotImplementedException();
            int sum = numbers.Sum();
            if (sum % 2 == 1) return true;
            else return false;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool upper=false, lower=false, number=false;
            //throw new NotImplementedException();
            for (int index = 0; index < password.Length; index++) {

                //upper
                if (Char.IsUpper(password[index])) upper = true;
                
                //lower
                if (Char.IsLower(password[index])) lower = true;

                //number
                if (Char.IsNumber(password[index])) number = true;
            }

            if (upper & lower & number) return true;
            else return false;
        }

        public char GetFirstLetterOfString(string val)
        {
            //throw new NotImplementedException();
            int index = 0;
            while (!Char.IsLetter(val[index]) && index<val.Length) {
                index++;
            }

            return val[index];
        }

        public char GetLastLetterOfString(string val)
        {
            //throw new NotImplementedException();
            int index = val.Length-1;
            while (!Char.IsLetter(val[index]) && index >=0)
            {
                index--;
            }

            return val[index];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            //throw new NotImplementedException();
            if (divisor == 0) return 0;
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            //throw new NotImplementedException();
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            //   throw new NotImplementedException();
            int[] odds=new int[200];
            int index = 0;
            while (index < 100) {
                if (index % 2 == 1) odds.Append(index);
                index++;
            }

            return odds;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            // throw new NotImplementedException();
            for (int index = 0; index < words.Length; index++) {
                for (int subindex = 0; subindex < words[index].Length; subindex++) {
                    words[index].ToUpper();
                }
            }
        }
    }
}
