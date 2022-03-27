namespace Codility
{
    internal class PermCheck
    {
		public static int solution(int[] A)
		{
			uint
				expected = (uint)((A.Length + ((A.Length + 1) % 2)) * Math.Ceiling(A.Length / 2.0)),
				sum = 0;
			HashSet<int> digits = new HashSet<int>(A);
			if (digits.Count != A.Length)
				return 0;
			for (int i = -1; ++i < A.Length; sum += (uint)A[i])
				;
			return sum == expected ? 1 : 0;
		}
	}

	/*A non-empty zero-indexed array A consisting of N integers is given.
	A permutation is a sequence containing each element from 1 to N once, and only once.
	For example, array A such that:
	A[0] = 4
	A[1] = 1
	A[2] = 3
	A[3] = 2
	is a permutation, but array A such that:

	A[0] = 4
	A[1] = 1
	A[2] = 3
	is not a permutation, because value 2 is missing.
	The goal is to check whether array A is a permutation.
	Write a function:
	class Solution { public int solution(int[] A); }
	that, given a zero-indexed array A, returns 1 if array A is a permutation and 0 if it is not.
	For example, given array A such that:
	A[0] = 4
	A[1] = 1
	A[2] = 3
	A[3] = 2
	the function should return 1.
	Given array A such that:
	A[0] = 4
	A[1] = 1
	A[2] = 3
	the function should return 0.
	Assume that:
	N is an integer within the range [1..100,000]; each element of array A is an integer within the range [1..1,000,000,000]. Complexity:
	expected worst-case time complexity is O(N); expected worst-case space complexity is O(N), beyond input storage (not counting the storage required for input arguments).
	 * */
}
