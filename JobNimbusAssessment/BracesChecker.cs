using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobNimubsAssessment
{
    public class BracesChecker
    {
        public bool AreBracesMatched(string input)
        {
            if (input.Length == 0 || input == "")
                return true;

            Stack<char> charStack = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                // Start adding only opening braces to the stack ...
                if (input[i] == '{')
                {
                    charStack.Push(input[i]);
                }

                //  When a closing brace exists ...
                if (input[i] == '}')
                {
                    // Once stack is checked for matching braces,
                    // if count is 0 but closing brace exists...
                    if (charStack.Count == 0)
                    {
                        return false;
                    }

                    // Pop the top element from stack (count decrements),
                    // and compare it to the latest closing brace ...
                    else if (!AreBracesPaired(charStack.Pop(), input[i]))
                    {
                        return false;
                    }
                }
            }

            // If all braces match, stack count will be 0 ...
            if (charStack.Count == 0)
            {
                return true;
            }
            // Otherwise, there will be at least one unmatched brace
            else
            {
                return false;
            }
        }

        private bool AreBracesPaired(char character1, char character2)
        {
            if (character1 == '{' && character2 == '}')
                return true;
            else
                return false;
        }
    }
}
