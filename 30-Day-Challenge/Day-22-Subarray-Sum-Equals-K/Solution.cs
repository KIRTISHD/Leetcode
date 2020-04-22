public class Solution {
    public int SubarraySum(int[] nums, int k) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        int result = 0;
        int sum = 0;
        dict.Add(0,1);
        
        for(int i = 0 ; i < nums.Length; i++)
        {
            sum += nums[i];
            
            if(dict.ContainsKey(sum-k))
                result += dict[sum-k];
            
            if (dict.ContainsKey(sum))
                dict[sum]++;
            else
                dict.Add(sum, 1);
        }
        
        return result;
    }
}
