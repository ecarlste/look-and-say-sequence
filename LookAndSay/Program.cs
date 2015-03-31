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
            LookAndSay lookAndSay = new LookAndSay();

            List<string> sequence = lookAndSay.Generate10("1");
        }
    }
}
