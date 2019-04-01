import java.util.HashMap;
import java.util.Map;

class Solution {
    public int[] twoSum(int[] nums, int target) {
        Map<Integer, Integer> need = new HashMap();
        int[] ans = new int[2];
        for(int i =0;i<nums.length;i++) {
            if (need.containsKey(target-nums[i])){
                ans[0]=need.get(target-nums[i]);
                ans[1]=i;
                break;
            }
            else{
                need.put(nums[i],i);
            }
        }
        return ans;
    }
}
