public class Solution {
  public int LastStoneWeight(int[] stones)
        {
            if (stones.Length == 2)
            {
                return Math.Abs(stones[1] - stones[0]);
            }

            Array.Sort(stones);
            List<int> s = new List<int>(stones);

            while (s.Count > 1)
            {
                int first = s.ElementAt(s.Count - 1);
                int second = s.ElementAt(s.Count - 2);
                int smash = first - second;
                s.RemoveAt(s.Count - 1);
                s.RemoveAt(s.Count - 1);

                if (smash != 0)
                {
                    int index = s.BinarySearch(smash);
                    if (index < 0)
                    {
                        index = ~index;
                    }
                    s.Insert(index, smash);
                }
            }
            return s.FirstOrDefault();
    }
}
