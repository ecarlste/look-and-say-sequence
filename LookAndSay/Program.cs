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
            List<string> sequence = LookAndSay.Generate10("1");
        }
    }
}
