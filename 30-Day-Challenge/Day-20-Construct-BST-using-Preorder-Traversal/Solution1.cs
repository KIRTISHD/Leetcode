/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public TreeNode BstFromPreorder(int[] preorder) {
        
        TreeNode root = new TreeNode();
        root.val = preorder[0];
        
        Stack<TreeNode> s = new Stack<TreeNode>();
        
        s.Push(root);
        
        for (int i = 1; i < preorder.Length; ++i)
        {
            TreeNode temp = null; 
  
            while (s.Count > 0 && preorder[i] > s.Peek().val) 
            { 
                temp = s.Pop(); 
            } 
            
            if (temp != null) 
            { 
                temp.right = new TreeNode(preorder[i]); 
                s.Push(temp.right); 
            } 
            
            else
            { 
                temp = s.Peek(); 
                temp.left = new TreeNode(preorder[i]); 
                s.Push(temp.left); 
            }
        }
        
        return root;
    }
}
