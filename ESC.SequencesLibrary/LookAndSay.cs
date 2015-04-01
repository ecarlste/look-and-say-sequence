using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESC.SequencesLibrary
{
    public class LookAndSay
    {
        public static string NextNumber(string number)
        {
            StringBuilder result = new StringBuilder();

            char repeat = number[0];
            number = number.Substring(1, number.Length-1)+" ";
            int times = 1;

            foreach (char actual in number)
            {
                if (actual != repeat)
                {
                    result.Append(Convert.ToString(times) + repeat);
                    times = 1;
                    repeat = actual;
                }
                else
                {
                    times++;
                }
            }

            return result.ToString();
        }

        public List<string> Generate10(string first)
        {
            List<string> first10 = new List<string>();
            first10.Add(first);

            do
            {
                // look at the item that is in the last position of the list and read it, for example 1 would be read as "1 1" or 11132 would be read as "3 1, 1 3, 1 2"
                
                // convert the string of numbers into a list of integers
                List<char> digitsAsChar = new List<char>(first10.Last().ToList());
                List<int> digits = digitsAsChar.ConvertAll<int>(x => (int)Char.GetNumericValue(x));
                List<int> newDigits = new List<int>();

                if (digits.Count == 1)
                {
                    newDigits.Add(1);
                    newDigits.Add(digits[0]);
                }

                // look at each digit of the number
                int digitCount = 1;

                for (int digitIndex = 1; digitIndex < digits.Count; digitIndex++)
                {
                    if (digitIndex == digits.Count - 1)
                    {
                        if (digits[digitIndex] == digits[digitIndex - 1])
                        {
                            newDigits.Add(digitCount + 1);
                            newDigits.Add(digits[digitIndex]);
                        }
                        else
                        {
                            newDigits.Add(digitCount);
                            newDigits.Add(digits[digitIndex - 1]);
                            newDigits.Add(1);
                            newDigits.Add(digits[digitIndex]);
                        }
                    }
                    else if (digits[digitIndex] != digits[digitIndex-1])
                    {
                        // if the digit we are checking is not the same as the last then we need to store the digit and the count based on the previously found digit
                        newDigits.Add(digitCount);
                        newDigits.Add(digits[digitIndex-1]);
                        digitCount = 1;
                    }
                    else
                    {
                        digitCount++;
                    }
                }

                // after collecting all the new digits in a list of digits, now we need to combine them into one number by contatenating them all
                List<string> newTermString = newDigits.ConvertAll<string>(x => x.ToString());

                first10.Add(String.Join("", newTermString));
            } while (first10.Count < 10);

            return first10;
        }
    }
}
