//Not my code

public class Solution {
    public IList<int> FindAnagrams(string s, string p)
    {
        int ns = s.Length;
        int np = p.Length;

        if (ns < np)
            return new List<int>();

        int[] pCount = new int[26];
        int[] sCount = new int[26];

        // build reference array using string p
        for (int i = 0; i < np; i++)
            pCount[p[i] - 'a']++;

        List<int> output = new List<int>();

        // sliding window on the string s
        for (int i = 0; i < ns; ++i)
        {
            // add one more letter
            // on the right side of the window
            sCount[s[i] - 'a']++;
            // remove one letter
            // from the left side of the window
            if (i >= np)
                sCount[s[i - np] - 'a']--;
            // compare array in the sliding window
            // with the reference array
            if (IsEqual(pCount, sCount))
                output.Add(i - np + 1);
        }

        return output;
    }
    
    public bool IsEqual(int[] pCount, int[] sCount)
    {
        for (int i = 0; i < 26; i++)
            if (pCount[i] != sCount[i])
                return false;

        return true;
    }
}
