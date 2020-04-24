public class LRUCache {
    
    class Node{
        
        public int Key;
        public int Value;
        public Node(int k, int v)
        {
            Key = k;
            Value = v;
        }
        
    }
    
    Dictionary<int, LinkedListNode<Node>> map = new Dictionary<int, LinkedListNode<Node>>();
    LinkedList<Node> list = new LinkedList<Node>();
    int count, size;

    public LRUCache(int capacity) {
       this.size = capacity; 
    }
    
    public int Get(int key) {
        
        if(map.ContainsKey(key))
        {
            int value = map[key].Value.Value;
            list.Remove(map[key]);
            list.AddLast(new Node(key, value));
            map[key] = list.Last;
            return value;
        }
        return -1;
        
    }
    
    public void Put(int key, int value) {
        
        if(map.ContainsKey(key))
        {
            list.Remove(map[key]);
            list.AddLast(new Node(key, value));
            map[key] = list.Last;
            return;
        }
        
        if(count == size)
        {
            LinkedListNode<Node> head = list.First;
            list.RemoveFirst();
            map.Remove(head.Value.Key);
            count--;
        }
        
        list.AddLast(new Node(key, value));
        map[key] = list.Last;
        count++; 
    }
}

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */
