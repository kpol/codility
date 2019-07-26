namespace Codility
{
    class CyclicRotation
    {
        public int[] solution(int[] A, int K)
        {
            if (A.Length == 0)
            {
                return new int[0];
            }

            var numberOfTimes = K % A.Length;
            var result = new int[A.Length];

            var index = numberOfTimes;

            for (int i = 0; i < A.Length; i++)
            {
                result[index] = A[i];

                if (index == A.Length - 1)
                {
                    index = 0;
                }
                else
                {
                    index++;
                }
            }

            return result;
        }
    }
}