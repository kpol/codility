using System.Collections.Generic;

namespace Codility
{
    class TreeHeight
    {
        public int solution(Tree T)
        {
            if (T.l == null && T.l == null)
            {
                return 0;
            }

            var stack = new Stack<TreePath>();

            AddNonNullTree(stack, T, 0);

            var max = 0;

            while (stack.Count > 0)
            {
                var t = stack.Pop();
                max = max > t.length + 1 ? max : t.length + 1;

                AddNonNullTree(stack, t.t, t.length + 1);
            }

            return max;
        }

        private static void AddNonNullTree(Stack<TreePath> stack, Tree t, int length)
        {
            if (t.l != null)
            {
                stack.Push(new TreePath { length = length, t = t.l });
            }

            if (t.r != null)
            {
                stack.Push(new TreePath { length = length, t = t.r });
            }
        }
    }

    class TreePath
    {
        public Tree t;

        public int length;
    }

    class Tree
    {
        public int x;
        public Tree l;
        public Tree r;
    };
}