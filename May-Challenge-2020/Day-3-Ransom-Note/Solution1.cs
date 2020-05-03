// Not my Code
public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        //Edge cases
        if(string.IsNullOrEmpty(magazine))
        {
            return !string.IsNullOrEmpty(ransomNote) ? false : true;
        }
        
        
        //Solution with Time Complexity O(M) & Space Compleixty O(1); M = size of magazine
        //index represent the char and value on these index represent the count of char
        int[] map = new int[26];
        
        for(int i = 0; i < magazine.Length; i++)
        {
            map[magazine[i] - 'a'] ++;
        }

        foreach(char c in ransomNote.ToCharArray())
        {
            int count = map[c - 'a'];
            
            if(count <= 0)
            {
                return false;
            }
            
            map[c - 'a'] --;
        }
        
        return true;
    }
}
