public class Solution {
    public int MaxSubarraySumCircular(int[] A) {
        
        int total_sum = 0;
        int max_ending_at = 0;
        int min_ending_at= 0;
        int max_sum = int.MinValue;
        int min_sum = int.MaxValue;
        
        foreach (int x in A)
        {
            total_sum += x;
            max_ending_at = Math.Max(max_ending_at + x, x);
            max_sum = Math.Max(max_ending_at, max_sum);
            min_ending_at = Math.Min(min_ending_at + x, x );
            min_sum = Math.Min(min_ending_at, min_sum);
        }
        
        if (max_sum > 0)
            return Math.Max(max_sum, total_sum - min_sum);
        
        return max_sum;
    }
}
