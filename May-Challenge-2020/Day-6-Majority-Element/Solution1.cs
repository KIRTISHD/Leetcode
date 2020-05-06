//Not my code

public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary<int, int> count = new Dictionary<int, int>();
        
        for(int i=0; i<nums.Length; i++){
            if(count.ContainsKey(nums[i])){
                count[nums[i]]++;
                
            }
            else{
                count.Add(nums[i], 1);
            }
            if(count[nums[i]] > nums.Length/2){
                    return nums[i];
                }
        }
        return Int32.MaxValue;
        
    }
}
