using System.Collections.Generic;

namespace Codility
{
    internal class MissingInteger
    {
        public static int solution(int[] A)
        {
            int min = 1;
            HashSet<int> numbers = new HashSet<int>();
            foreach (int n in A)
            {
                if (!numbers.Contains(n))
                {
                    numbers.Add(n);
                    if (n == min)
                        while (numbers.Contains(++min)) ;
                }
            }
            Console.WriteLine(min);
            return min;

        }
    }

    /*
    Write a function:
    class Solution { public int solution(int[] A); }
        that, given an array A of N integers, returns the smallest positive integer(greater than 0) that does not occur in A.
       For example, given A = [1, 3, 6, 4, 1, 2], the function should return 5.
    Given A = [1, 2, 3], the function should return 4.
    Given A = [−1, −3], the function should return 1.
    Write an efficient algorithm for the following assumptions:
    N is an integer within the range[1..100, 000];
    each element of array A is an integer within the range[−1, 000, 000..1, 000, 000].
    */
}
