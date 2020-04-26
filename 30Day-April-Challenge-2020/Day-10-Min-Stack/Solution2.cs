public class MinStack {
    
    private System.Collections.Generic.IList<int> s;

		protected class Node{
			public int min;
			public int val;
			public Node prev;
			
			public Node(int min, int val, Node prev){
				this.min = min;
				this.val = val;
				this.prev = prev;
			}
		}
		
		Node head;

		/** initialize your data structure here. */
		public MinStack() {
			head = null;
		}

		public void Push(int x) {
			if (head == null){
				head = new Node(x, x, null);
			}
			else{
				if (x > head.min)
				{
					Node newnode = new Node(head.min,x,head);
					head = newnode;
				}
				else
				{
					Node newnode = new Node(x,x,head);
					head = newnode;
				}
			}
		}

		public void Pop() {
			head = head.prev;
		}

		public int Top() {
			return head.val;
		}

		public int GetMin() {
			return head.min;
		}
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(x);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */
