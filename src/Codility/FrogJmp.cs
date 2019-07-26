using System;

namespace Codility
{
    class FrogJmp
    {
        public int solution(int X, int Y, int D)
        {
            var distance = Y - X;

            return (int) Math.Ceiling((double)distance / D);
        }
    }
}