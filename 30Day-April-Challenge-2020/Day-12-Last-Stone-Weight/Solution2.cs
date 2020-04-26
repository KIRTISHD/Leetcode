public class Solution {
    public int LastStoneWeight(int[] stones) {
        int len = stones.Length;
        if (len == 0)
          return stones[0];
            System.Array.Sort(stones);
        for (int i = len - 1; i > 0; i--){
          if (i == 1 && stones[i] == stones[i-1])
            return 0;

          if (stones[i] == stones[i-1])
            i--;
          else
            stones[i-1] = Math.Abs(stones[i-1] - stones[i]);

            System.Array.Sort(stones);
        }
        return stones[0];
    }
}
