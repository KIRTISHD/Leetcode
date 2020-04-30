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
    public bool IsValidSequence(TreeNode root, int[] arr) {
        if (root == null)
            return arr.Length == 0;
        
        return isValid(root, arr, 0);
    }
    
    public bool isValid(TreeNode root, int[] arr, int num)
    {
        if (root.val != arr[num])
            return false;
        
        if (num == arr.Length - 1)
            return root.left == null && root.right == null;
        
        return (
            (root.left != null && isValid(root.left, arr, num+1)) ||
            (root.right != null && isValid(root.right, arr, num+1))
        );
    }
}
