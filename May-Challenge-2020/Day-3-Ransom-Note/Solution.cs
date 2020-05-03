public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
     
        Dictionary<char, int> map = new Dictionary<char, int>();
        
        foreach (char c in magazine.ToCharArray())
        {
            if (map.ContainsKey(c))
                map[c] = (map[c] + 1);
            else
                map.Add(c, 1);
        }
        
        foreach(char c in ransomNote.ToCharArray())
        {
            if (!map.ContainsKey(c) || map[c] == 0)
                return false;
        
            map[c] = (map[c] - 1);
        }
        
        return true;
    }
}
