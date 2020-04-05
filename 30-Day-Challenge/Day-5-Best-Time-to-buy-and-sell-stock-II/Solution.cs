public class Solution {
    public int MaxProfit(int[] prices) {
        int sum = 0;
        if (prices.Length == 1)
            return sum;
        for(int i = 0; i < prices.Length - 1; i++) {
            if (prices[i+1] > prices[i])
                sum += prices[i+1] - prices[i];
        }
        return sum;
    }
}
