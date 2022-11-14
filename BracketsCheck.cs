using System;
using System.Linq;

namespace ClearBrackets
{
    class Working
    {
        public bool CheckBrackets(string b)
        {
            int i = b.Where(bracket => (bracket == '(')).Count();
            
            return true;
        }
    }
}