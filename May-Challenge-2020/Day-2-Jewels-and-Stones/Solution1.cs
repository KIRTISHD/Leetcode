public class Solution {
    public int NumJewelsInStones(string J, string S) {
        int count = 0;
        for(int i = 0; i < S.Length; i++)
        {
            if (J.Contains(S[i]))
                count++;
        }
        return count;
    }
}
