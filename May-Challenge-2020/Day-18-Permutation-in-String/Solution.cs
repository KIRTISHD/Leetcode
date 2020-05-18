public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        int[] map = new int[26];
        foreach(char c in s1)
            map[c - 'a']++;
        int i = 0;
        int j = 0;
        int len = s1.Length;
        
        while (j < s2.Length)
        {
            if (map[s2[j++] - 'a']-- > 0)
                len--;
            if (len == 0)
                return true;
            if (j - i == s1.Length && map[s2[i++] - 'a']++ >= 0)
                len++;
        }
        return false;
    }
}
