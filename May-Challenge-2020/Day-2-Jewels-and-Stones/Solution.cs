public class Solution {
    public int NumJewelsInStones(string J, string S) {
        var bag = J.ToHashSet();
        return S.Count(bag.Contains);
    }
}
