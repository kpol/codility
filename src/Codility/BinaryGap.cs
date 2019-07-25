using System;

namespace Codility
{
    class BinaryGap
    {
        public int solution(int N)
        {
            var firstOne = (int)Math.Log(N, 2);
            var length = 0;
            int maxLength = 0;
            var n = 1 << firstOne;

            while ((n = n >> 1) != 0)
            {
                var res = n & N;

                if (res == n && length != 0) // 1
                {
                    maxLength = maxLength < length ? length : maxLength;
                    length = 0;
                }
                else //0
                {
                    length++;
                }
            }

            return maxLength;
        }
    }
}