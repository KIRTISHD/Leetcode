public class Solution {
    public string StringShift(string s, int[][] shift) {
        int lShift = 0;
        int rShift = 0;
        int len = s.Length;
        string res = "";

        if (len == 1)
          return s;

        for(int i = 0; i < shift.GetLength(0); i++)
        {
          if (shift[i][0] == 0)
            lShift += shift[i][1];

          else if (shift[i][0] == 1)
            rShift += shift[i][1];

        }
        if (lShift > rShift) 
        {
          lShift -= rShift;
          lShift %= len;
          res += s.Substring(lShift, len - lShift);
          res += s.Substring(0, lShift);
        }
        else 
        {

          rShift -= lShift;
          rShift %= len;
          res += s.Substring(len - rShift, rShift);
          res += s.Substring(0, len - rShift);
        }
        return res;
    }
}
