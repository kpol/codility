using System;
using System.ComponentModel.DataAnnotations;

namespace Codility
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = 529;

            Console.WriteLine(Convert.ToString(N, 2));

            var result = new CyclicRotation().solution(new int[]{}, 1);

            Console.WriteLine(result);
        }
    }
}
