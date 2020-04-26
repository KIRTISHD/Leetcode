public class Solution {
    public int FindMaxLength(int[] nums) {
        System.Collections.Generic.IDictionary<int, int> map = new System.Collections.Generic.Dictionary<int, int>();
		int maxLength = 0;
		int count = 0;
		map.Add(0,-1);
		
		for (int i = 0; i < nums.Length; i++)
		{
			if (nums[i] == 0)
				count --;
			else
				count++;
			
			if (map.ContainsKey(count))
				maxLength = Math.Max(maxLength, i-map[count]);
			else
				map.Add(count, i);
		}
		
		return maxLength;
    }
}
