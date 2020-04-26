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
    int max = 0 ;
    
    public int DiameterOfBinaryTree(TreeNode root) {
       helper(root);
        return max;
    }
    
    public int helper(TreeNode root){
        if (root == null)
          return 0;
    
        var left = helper(root.left);
        var right= helper(root.right);
        max = Math.Max(right + left, max);
        
        return Math.Max(left, right) + 1;
    }
}
