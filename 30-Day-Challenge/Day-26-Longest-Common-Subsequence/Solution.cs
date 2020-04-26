public class Solution {
    public int LongestCommonSubsequence(string text1, string text2) {
    
        if (string.IsNullOrEmpty(text1) || string.IsNullOrEmpty(text2))
            return 0;
        int strLen1 = text1.Length;
        int strLen2 = text2.Length;
        
        int [,] LCS = new int[strLen1+1, strLen2+1];
        
        for(int i = 0; i <= strLen1; i++)
        {
            for(int j = 0; j <= strLen2; j++)
            {
                if (i == 0 || j == 0) 
                    LCS[i, j] = 0; 
                else if (text1[i - 1] == text2[j - 1]) 
                    LCS[i, j] = LCS[i - 1, j - 1] + 1; 
                else
                    LCS[i, j] = Math.Max(LCS[i - 1, j], LCS[i, j - 1]); 
            }
        }
        
        return LCS[strLen1, strLen2];
    }
}
