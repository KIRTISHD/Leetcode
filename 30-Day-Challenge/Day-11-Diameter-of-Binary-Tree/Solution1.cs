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
    
    public int height(TreeNode node){
        if (node == null)
            return 0;
        
        return (1 + Math.Max(height(node.left),height(node.right)));
    }
    
    
    public int DiameterOfBinaryTree(TreeNode root) {
        if (root == null)
            return 0;
        
        int l_height = height(root.left);
        int r_height = height(root.right);
        
        int l_dia = DiameterOfBinaryTree(root.left);
        int r_dia = DiameterOfBinaryTree(root.right);
        
        return Math.Max(l_height + r_height , Math.Max(l_dia,r_dia));
    }
}
