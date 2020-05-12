public class Solution {
    public int SingleNonDuplicate(int[] nums) {
        if (nums == null || nums.Length == 0) {
            return 0;
        }
        
        int len = nums.Length;
        
        if (len == 1)
            return nums[0];
        
        for (int i = 0, j = 1; i < len-1; i += 2)
        {
            if (nums[i] != nums[j])
            {
                return nums[i];
            }
            j += 2;
        }
        
        return nums[len - 1];
        
    }
}
