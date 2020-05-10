public class Solution {
    public int FindJudge(int N, int[][] trust) {
        if (trust.Length == 0)
            return N;
        
        int[] count = new int[N+1];
        foreach(int[] t in trust)
        {
            count[t[0]]--;
            count[t[1]]++;
        }
        for ( int i = 0 ; i <= N ; i++)
        {
            if (count[i] == N-1)
                return i;
        }
        
        return -1;
    }
}
