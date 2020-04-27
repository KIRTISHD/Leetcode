//Not my Code. But a faster version using DP.
public class Solution {
    public int MaximalSquare(char[][] matrix) {
       
       if (matrix.Length == 0 || matrix[0].Length == 0) return 0;
            int[][] dp = new int[matrix.Length][];
            for (int i = 0; i < matrix.Length; i++)
            {
                dp[i] = new int[matrix[i].Length];
            }
            int max = 0;
            for (int i = 0; i < dp.Length; i++)
            {
                for (int j = 0; j < dp[i].Length; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        if (matrix[i][j] == '1') dp[i][j] = 1;
                    }
                    else
                    {
                        if (matrix[i][j] == '1')
                        {
                            dp[i][j] = Math.Min(dp[i][j - 1], Math.Min(dp[i - 1][j], dp[i - 1][j - 1])) + 1;
                        }
                    }
                    max = Math.Max(dp[i][j], max);
                }
            }
            return max * max;
    }
}
