namespace Codility
{
    public class BitMultiplication
    {
        public static int solution(int A, int B)
        {
            int count = 0;
            ulong multiplicationAB = (ulong)(A * B);

            for (uint i = 1; i <= multiplicationAB; i <<= 1)
            {
                if ((i & multiplicationAB) != 0)
                    count++;
            }


            return count;
        }
    }

    /*Write a function 
      class Solution { public int solution(int A, int B);}
      that, given two non-negative integers A and B, returns the number of bits set to 1
      in the binary representation of the number A*B.

     For example, given A = 3 and B = 7 the function should return 3, because the binary
     representation of A*B = 3*7=21 is 10101 and it contains three bits set to 1.
     Assume that
        .A and B are integers within the range [0..100,000,000].
    Focus on correctness
     
      
     */
}
