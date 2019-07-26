using System.Collections.Generic;

namespace Codility
{
    class PermMissingElem
    {
        public int solution(int[] A)
        {
            var set = new HashSet<int>(A);

            for (int i = 0; i < A.Length + 1; i++)
            {
                if (!set.Contains(i + 1))
                {
                    return i + 1;
                }
            }

            return 0;
        }
    }
}