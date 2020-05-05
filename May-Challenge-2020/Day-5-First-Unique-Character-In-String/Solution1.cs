//Not my code

public class Solution {
    public int FirstUniqChar(string s) {
        if(string.IsNullOrEmpty(s))
            return -1;
        
        int[] noOfInstance = new int[26]; 
            
        for(int i = 0; i < s.Length; i++)
        {
            noOfInstance[s[i]] += 1;
        }
        
        for(int j = 0; j< s.Length; j++)
        {
            if(noOfInstance[s[j]] == 1)
                return j;
        }
        
        return -1;
    }
}
