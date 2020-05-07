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
    
    public int GetHeight(TreeNode root, int x, int height)
    {
        if (root == null)
            return 0;
        
        if (root.val == x)
            return height;
        int currHeight = GetHeight(root.left, x, height+1);
        if (currHeight != 0)
            return currHeight;
        
        return GetHeight(root.right, x, height+1);
    }
    
    public bool SameParents(TreeNode root, int x, int y)
    {
        if (root == null)
            return false;
        
        if (root.left != null && root.right != null)
        {
            return ((root.left.val == x && root.right.val == y) ||
                (root.left.val == y && root.right.val == x) ||
                (SameParents(root.left, x, y)) ||
                (SameParents(root.right, x, y)));
        }
        else {
            return ((SameParents(root.left, x, y)) ||
                    (SameParents(root.right, x, y)));
        }
        
    }
    
    public bool IsCousins(TreeNode root, int x, int y) {
        
        //first checking if the height of both nodes is same
        if (GetHeight(root, x, 1) != GetHeight(root, y, 1))
            return false;
        
        //Now check if parents are same of not
        if (SameParents(root, x, y) == true)
            return false;
        else
            return true;
    }
}
