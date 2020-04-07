public class Solution {
    public int CountElements(int[] arr) {
        System.Array.Sort(arr);
		int total = 0;
		int dups = 0;
		for(int i = 0; i < arr.Length - 1; i++){
			if (arr[i] == arr[i+1])
				dups++;
			else{
				if (arr[i]+1 == arr[i+1])
					total += dups + 1;
				dups = 0;
			}
		}
		return total;
    }
}
