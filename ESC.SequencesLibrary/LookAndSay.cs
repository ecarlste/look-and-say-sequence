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

        public static List<string> GenerateSequence(string firstNumber, int termCount)
        {
            List<string> sequence = new List<string>();
            sequence.Add(firstNumber);

            for (int currentCharacter = 1; currentCharacter < termCount; currentCharacter++)
            {
                string nextNumber = NextNumber(sequence.Last());
                sequence.Add(nextNumber);
            }

            return sequence;
        }

        public static List<string> Generate10(string firstNumber)
        {
            return GenerateSequence(firstNumber, 10);
        }
    }
}
