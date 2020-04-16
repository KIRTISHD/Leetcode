public class Solution {
    public bool CheckValidString(string s) {
        int len = s.Length;
        if (s == null || len == 0)
            return true;
        
        int low = 0;
        int high = 0;
        for (int i = 0; i < len; i++) {
            char c = s[i];
 
            if (c == '(') 
            {
                low++;
                high++;
            } 
            else if (c == ')') 
            {
                if (low > 0) 
                {
                    low--;
                }
                high--;
            } 
            else 
            {
                if (low > 0) 
                {
                    low--;
                }
                high++;
            }
 
            if (high < 0) 
            {
                return false;
            }
        }
 
        return low == 0;
    }
}
