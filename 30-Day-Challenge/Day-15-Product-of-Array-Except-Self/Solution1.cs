public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int temp = 1;
        int len = nums.Length;
        int[] res = new int[len];
        
        res[0] = 1;
        
        for(int i = 0; i < len; i++){
            res[i] = temp;
            temp *= nums[i];
        }
        
        temp = 1;
        for(int i = len - 1; i >= 0; i--){
            res[i] *= temp;
            temp *= nums[i];
        }
        
        return res;
    }
}
