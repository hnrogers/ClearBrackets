using System;
using System.Linq;

namespace ClearBrackets
{
    class Primary
    {
        public static void Main()
        {
            Working working = new Working();
            Console.WriteLine(working.CheckBrackets("(1 + (5 + 5) - (5 + 4))"));
            Console.WriteLine(working.CheckBrackets("1 + 2"));
            Console.WriteLine(working.CheckBrackets("(1 + 2"));
        }
    }
}