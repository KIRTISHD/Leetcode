class Solution {
    public int findNumbers(int[] nums) {
        int sum = 0;
		for(Integer i : nums) {
			if (i.toString().length()%2 == 0) {
				sum+=1;
			}
		}
		return sum;
    }
}
