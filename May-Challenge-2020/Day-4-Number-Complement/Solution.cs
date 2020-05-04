public class Solution {
    public int FindComplement(int num) {
        if (num == 0)
            return 1;

        int leftMost = 31;

        for(int i = 31 ; i >= 0 ; i--)
        {
            if((num & (1 << i)) > 0)
            {
                leftMost = i;
                break;
            }
        }

        return num ^ ((1 << (leftMost + 1)) - 1);
    }
}
