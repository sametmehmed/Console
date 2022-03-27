namespace Codility
{
    public class MaxDistance
    {
        public static int solution(int[] blocks)
        {
            int[] totalJump = new int[blocks.Length];
            int jumpCount = 0;
            int maxJumpCount = 0;

            //Count right jumps
            for (int i = 0; i < blocks.Length - 1; i++)
            {
                if (blocks[i] <= blocks[i + 1])
                {
                    jumpCount++;
                    for (int j = 0; j < jumpCount; j++)
                        totalJump[i - j]++;
                }
                else
                    jumpCount = 0;
            }

            jumpCount = 0;

            //Count left jumps
            for (int i = blocks.Length -1; i > 0; i--)
            {
                if (blocks[i - 1] >= blocks[i])
                {
                    jumpCount++;
                    for (int j = 0; j < jumpCount; j++)
                        totalJump[i + j]++;
                }
                else
                    jumpCount = 0;
            }

            foreach(int i in totalJump)
            {
                if (maxJumpCount < i)
                    maxJumpCount = i;
            }

            Console.WriteLine(maxJumpCount+1);
            return maxJumpCount+1;
        }
    }
}
