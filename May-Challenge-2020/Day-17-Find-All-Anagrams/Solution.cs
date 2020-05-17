public class Solution {
    public IList<int> FindAnagrams(string s, string p) {
        
        IList<int> res = new List<int>();
        if (s == null || s.Length == 0)
            return res;
        
        int[] char_count = new int[26];
        
        foreach(char c in p){
            char_count[c - 'a']++;
        }
        
        int left = 0;
        int right = 0;
        int len = p.Length;
        
        while (right < s.Length) {
            if (char_count[s[right++] - 'a']-- >= 1)
                len--;
            if(len == 0)
                res.Add(left);
            if (right - left == p.Length && char_count[s[left++] - 'a']++ >= 0)
                len++;
        }
        
        return res;
    }
}
