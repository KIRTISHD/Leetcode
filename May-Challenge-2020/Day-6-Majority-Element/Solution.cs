public class Solution {
    public int MajorityElement(int[] nums) {
        
        int m = -1;
        int i = 0;
        
        foreach(int temp in nums)
        {
            if (i == 0)
            {
                m = temp;
                i = 1;
            }
            else if (m == temp)
                i++;
            else
                i--;
        }
        
        return m;
    }
}
