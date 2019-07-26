namespace Codility
{
    class OddOccurrencesInArray
    {
        public int solution(int[] A)
        {
            var x = A[0];
            
            for (int i = 1; i < A.Length; i++)
            {
                x ^= A[i];
            }

            return x;
        }
    }
}