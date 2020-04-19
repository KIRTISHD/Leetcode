public class Solution {
    
    public int BinarySearch(int[] nums, int low, int high, int key)
    {
        if (low > high)
            return -1;
        
        int mid = (low + high) / 2;
        
        if (nums[mid] == key)
            return mid;
        
        if (nums[low] <= nums[mid])
        {
            if (key >= nums[low] && key <= nums[mid])
                return BinarySearch(nums, low, mid-1, key);
            return BinarySearch(nums, mid+1, high, key);
        }
        
        if (key >= nums[mid] && key <= nums[high])
            return BinarySearch(nums, mid+1, high, key);
        
        return BinarySearch(nums, low, mid-1, key);
    }
    
    public int Search(int[] nums, int target) {
        return BinarySearch(nums, 0, nums.Length-1, target);
    }
}
