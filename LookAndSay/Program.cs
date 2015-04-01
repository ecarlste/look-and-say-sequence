using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESC.SequencesLibrary;

namespace LookAndSayApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string secondTerm = LookAndSay.NextNumber("1");
            List<string> sequence1 = LookAndSay.Generate10("1");
            List<string> sequence2 = LookAndSay.GenerateSequence("1", 10);
        }
    }
}
