public class Solution {
    public int MaximalSquare(char[][] matrix) {
        int rows = matrix.Length;
        int cols = 0;
        if (rows > 0)
            cols = matrix[0].Length;
        
        int[] tempArray = new int[cols + 1];
        
        int prev = 0;
        int max = 0;
        
        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= cols; j++)
            {
                int temp = tempArray[j];
                
                if (matrix[i-1][j-1] == '1')
                {
                    tempArray[j] = Math.Min( Math.Min(tempArray[j-1], prev), tempArray[j]) + 1;
                    max = Math.Max(max, tempArray[j]);
                }
                else 
                {
                    tempArray[j] = 0;
                }
                prev = temp;
            }
        }
        
        return max * max;
    }
}
