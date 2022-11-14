using System;
using System.Linq;

namespace ClearBrackets
{
    class Working
    {
        private int openingBrackets, closingBrackets;
        public bool CheckBrackets(string b)
        {
            openingBrackets = b.Where(bracket => (bracket == '(')).Count();
            closingBrackets = b.Where(bracket => (bracket == ')')).Count();

            return openingBrackets == closingBrackets;
        }
    }
}