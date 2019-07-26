namespace Codility
{
    class TieRopes
    {
        public int solution(int K, int[] A)
        {
            var length = 0;
            var count = 0;

            foreach (var rope in A)
            {
                length += rope;

                if (length >= K)
                {
                    length = 0;
                    count++;
                }
            }

            return count;
        }
    }
}