public class Solution {
   
    
    /*public int MinPathSum(int[][] grid) {
        if (grid == null || grid.Length == 0)
            return 0;
        
        int[,] dp = new int[grid.Length,grid[0].Length];
        
        for(int i = 0; i < dp.Length; i++)
        {
            for(int j = 0; j < grid[i].Length; j++)
            {
                dp[i,j] += grid[i][j];
                if(i > 0 && j > 0)
                    dp[i,j] += Math.Min(dp[i-1,j],dp[i,j-1]);
                else if (i > 0)
                    dp[i,j] += dp[i-1,j];
                else if (j > 0)
                    dp[i,j] += dp[i,j-1];
                
            }
        }
        
    return dp[dp.Length - 1,grid[0].Length -1];
    }*/
    
    public int MinPathSum(int[][] grid)
    {
        var n = grid.Length;
        if (n == 0) return 0;

        var m = grid[0].Length;

        var dp = new int[n, m];

        for (int i = 0; i < n; i++) {
            for (int j = 0; j < m; j++) {
                if (i == 0 && j == 0) {
                    dp[i, j] = grid[i][j];
                } else if (i == 0) {
                    dp[i, j] = dp[i, j - 1] + grid[i][j];
                } else if (j == 0) {
                    dp[i, j] = dp[i - 1, j] + grid[i][j];
                } else {
                    dp[i, j] = Math.Min(dp[i - 1, j], dp[i, j - 1]) + grid[i][j];
                }
            }
        }

        return dp[n - 1, m - 1];
    }
    
}
