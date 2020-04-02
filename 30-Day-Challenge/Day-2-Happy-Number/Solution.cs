public class Solution {
    public bool IsHappy(int n) {
        System.Collections.Generic.HashSet<int> mySet = new System.Collections.Generic.HashSet<int>();
		mySet.Add(n);
		while(n != 1){
			
			int newnum = n;
			int sum = 0;
			while (newnum != 0) {
				int temp = newnum % 10;
				sum += (temp*temp);
				newnum /= 10;
			}
			n = sum;
			if(mySet.Contains(n))
				return false;
			mySet.Add(n);
		}
		return true;
    }
}
