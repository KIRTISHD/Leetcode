/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    
    class Value{
        int val;
    }
    
    public int MaxUntil(TreeNode node, int max)
    {
        if (node == null)
            return 0;
        
        int lSum = MaxUntil(node.left, max);
        int rSum = MaxUntil(node.right, max);
        
        int max_node_val = Math.Max(Math.Max(lSum, rSum) + node.val, node.val); 
        
        int max_till_now = Math.Max(max_node_val, lSum + rSum + node.val); 
        
        max = Math.Max(max, max_till_now);
        
        return max_node_val;
        
    }
    public int MaxPathSum(TreeNode root) {
        return MaxUntil(root, int.MinValue);
    }
}
