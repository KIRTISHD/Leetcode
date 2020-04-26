public class MinStack {
    
    private System.Collections.Generic.IList<int> s;

		/** initialize your data structure here. */
		public MinStack() {
			s = new System.Collections.Generic.List<int>() ;
		}

		public void Push(int x) {
			s.Add(x);
		}

		public void Pop() {
			s.RemoveAt(s.Count - 1);
		}

		public int Top() {
			return s[(s.Count - 1)];
		}

		public int GetMin() {
			return s.Min();
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
