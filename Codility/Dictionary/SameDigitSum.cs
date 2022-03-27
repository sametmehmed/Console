namespace Codility
{
    internal class SameDigitSum
    {
        public static int solution(int[] A)
        {
            Dictionary<int, int> mp = new Dictionary<int, int>();
            int ans = -1, pairi = 0, pairj = 0;
            for (int i = 0; i < A.Length; i++)
            {

                // Store the current sum of digits
                // of the number in temp
                int temp = digitSum(A[i]);

                // If temp is already present
                // in the map then update
                // ans if the sum is greater
                // than the existing value
                if (mp.ContainsKey(temp))
                {
                    if (A[i] + mp[temp] > ans)
                    {
                        pairi = A[i];
                        pairj = mp[temp];
                        ans = pairi + pairj;
                    }
                    mp[temp] = Math.Max(A[i], mp[temp]);
                }
                else
                    mp[temp] = A[i];

            }

            Console.WriteLine(pairi + " " + pairj + " " + ans);
            return ans;
        }

        static int digitSum(long n)
        {
            int sum = 0;
            while (n > 0)
            {
                sum += (int)(n % 10);
                n /= 10;
            }
            return sum;
        }
    }
}
