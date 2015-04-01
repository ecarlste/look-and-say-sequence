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

            for (int currentCharacter = 1; currentCharacter < 10; currentCharacter++)
            {
                string nextNumber = NextNumber(first10.Last());
                first10.Add(nextNumber);
            }

            return first10;
        }
    }
}
