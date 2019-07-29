using System.Collections.Generic;

namespace Codility
{
    class Brackets
    {
        public int solution(string S)
        {
            var stack = new Stack<char>();

            foreach (var c in S)
            {
                if (c == '{' || c == '(' || c == '[')
                {
                    stack.Push(c);
                }
                else if (c == '}' || c == ')' || c == ']')
                {
                    if (stack.Count == 0)
                    {
                        return 0;
                    }

                    var open = stack.Pop();

                    if (c == '}' && open != '{'
                        || c == ')' && open != '('
                        || c == ']' && open != '[')
                    {
                        return 0;
                    }

                }
            }

            return stack.Count == 0 ? 1 : 0;
        }
    }
}