public class Solution {
    public bool CanJump(int[] nums) {
        if (nums == null)
            return false;
        
        int len = nums.Length;
        int pointer = len - 1;
        
        if (len == 1)
            return true;
            
        for (int i = len - 1; i >= 0; i--)
        {
            if (i + nums[i] >= pointer)
            {
                pointer = i;
            }
        }
        
        return (pointer == 0);
    }
}
