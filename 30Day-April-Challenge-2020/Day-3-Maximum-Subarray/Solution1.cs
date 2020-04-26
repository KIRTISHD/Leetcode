public class Solution1 {
    public int MaxSubArray(int[] nums) {
        return maxSum(nums, 0, nums.Length-1);
    }
    public int Max(int a, int b, int c){
		return (a > b) ? ( (a > c) ? a : c )  : (b > c) ? b : c ;
	}
	
	public int maxCrossArray(int[] arr, int low, int mid, int high){
		
		int lowSum = Int32.MinValue, sum = 0;
		
		for(int i = mid; i >= low; i--){
			sum += arr[i];
			if(lowSum < sum)
				lowSum = sum;
		}
		
		int highSum = Int32.MinValue;
		sum = 0;
		
		for(int i = mid + 1; i <= high; i++){
			sum += arr[i];
			if(highSum < sum)
				highSum = sum;
		}
		
		return (lowSum + highSum);
	}
	
	public int maxSum(int []arr, int lowIndex, int highIndex){
		
		if (lowIndex == highIndex)
			return arr[lowIndex];
		
		int midIndex = (lowIndex+highIndex)/2;
		
		int lowSum = maxSum(arr, lowIndex, midIndex);
		int highSum = maxSum(arr, midIndex + 1, highIndex);
		int centerSum = maxCrossArray(arr, lowIndex, midIndex, highIndex);
		
		return Max(lowSum, centerSum, highSum);
	}
}
