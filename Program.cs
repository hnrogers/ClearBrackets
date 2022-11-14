using System;
using System.Linq;

namespace ClearBrackets
{
    class Primary
    {
        public static void Main()
        {
            Working working = new Working();
            working.CheckBrackets("(((");
        }
    }
}