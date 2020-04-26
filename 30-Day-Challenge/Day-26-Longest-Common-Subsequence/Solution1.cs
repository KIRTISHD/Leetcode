// Not My Code, Found on Leetcode Discussion. Is Faster than Mine- 

public class Solution {
    public int LongestCommonSubsequence(string text1, string text2) {
        if(string.IsNullOrEmpty(text1) && string.IsNullOrEmpty(text2))
            return 0;
        
        var m = text1.Length;
        var n = text2.Length;
        var max = 0;
        
        var dp = new int[m + 1, n + 1];
        
        for(var i = 1; i <= m; i++)
        {
            for(var j = 1; j <= n; j++)
            {
                if(text1[i - 1] == text2[j - 1])
                    dp[i, j] = 1 + dp[i - 1, j - 1];
                else
                    dp[i, j] = Math.Max(dp[i, j - 1], dp[i - 1, j]);
                
                max = Math.Max(dp[i, j], max);
            }
        }
        
        return max;
    }
}
