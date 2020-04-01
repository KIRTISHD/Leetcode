class Solution {
    public int singleNumber(int[] nums) {
        java.util.Set<Integer> temp = new java.util.HashSet<Integer>();
        for(int i : nums){
            if(temp.contains(i)){
				temp.remove(i);
			}
			else
				temp.add(i);
        }
        java.util.Optional<Integer> firstElement = temp.stream().findFirst();
        return firstElement.get();
    }
}
