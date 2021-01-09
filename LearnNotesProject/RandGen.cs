using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnNotesProject
{
    static class RandGen
    {
        static private Random rand = new Random();

        public static int Generate(int a, int b)
        {
            return rand.Next(a, b);
        }
    }
}
