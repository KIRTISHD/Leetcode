public class Solution {
    public int FirstUniqChar(string s) {
        if (s == null)
			return -1;
		
        int len = s.Length;
		
		if (len == 1)
			return 0;
		
        Dictionary<char, int> map = new Dictionary<char, int>();
        int firstocc = int.MaxValue;
        
        for (int i = 0 ; i < len ; i++)
        {
            if (map.ContainsKey(s[i]))
                map[s[i]] = -1;
            
            else
                map.Add(s[i], i);
        }
        
        foreach(var item in map)
        {
            if (item.Value > -1 && item.Value < firstocc)
				firstocc = item.Value;
        }
        
		return (firstocc == int.MaxValue) ? -1 : firstocc;
        
    }
}
