using System.Linq;

namespace Codility
{
    class MissingInteger
    {
        public int solution(int[] A)
        {
            var res = A.Where(i => i > 0).Distinct().OrderBy(i => i);

            var min = 1;

            foreach (var x in res)
            {
                if (x != min)
                {
                    return min;
                }

                min++;
            }

            return min;
        }
    }
}