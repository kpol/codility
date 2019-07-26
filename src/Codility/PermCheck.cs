using System.Collections;

namespace Codility
{
    class PermCheck
    {
        public int solution(int[] A)
        {
            var bitArray = new BitArray(A.Length);

            foreach (var i in A)
            {
                if (i <= 0 || i > A.Length)
                {
                    return 0;
                }

                if (bitArray[i - 1])
                {
                    return 0;
                }

                bitArray[i - 1] = true;
            }

            foreach (bool b in bitArray)
            {
                if (!b)
                {
                    return 0;
                }
            }

            return 1;
        }
    }
}