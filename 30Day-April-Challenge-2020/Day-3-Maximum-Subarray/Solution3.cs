public class Solution3 {
    public int MaxSubArray(int[] nums) {
    
        int sum = nums[0];
        
        for(int i = 1; i < nums.Length; i++){
          if (nums[i-1] + nums[i] > nums[i])
            nums[i] += nums[i-1];
          
          if (nums[i] > sum)
            sum = nums[i]
        }
        return sum;
    }
}
