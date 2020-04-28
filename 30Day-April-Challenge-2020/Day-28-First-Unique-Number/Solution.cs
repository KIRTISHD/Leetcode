public class FirstUnique {
    
    Dictionary<int, LinkedListNode<int>> map = new Dictionary<int, LinkedListNode<int>>();
    LinkedList<int> list = new LinkedList<int>();

    public FirstUnique(int[] nums) {
        for(int i = 0; i < nums.Length; i++)
        {
            Add(nums[i]);
        }
        
    }
    
    public int ShowFirstUnique() {
        LinkedListNode<int> temp = list.First;
        if (temp == null)
            return -1;
        else
            return list.First.Value;
    }
    
    public void Add(int value) {
        if (map.ContainsKey(value))
        {
            if (map[value] != null)
            {
                list.Remove(map[value]);
                map[value] = null;
            }
        }
        else
        {
            list.AddLast(value);
            map.Add(value,list.Last);
        }
    }
}

/**
 * Your FirstUnique object will be instantiated and called as such:
 * FirstUnique obj = new FirstUnique(nums);
 * int param_1 = obj.ShowFirstUnique();
 * obj.Add(value);
 */
