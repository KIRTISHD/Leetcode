//Not my Code
public class Solution {
    
     public int finalsum = Int32.MinValue;
        public int MaxPathSum(TreeNode root)
        {
            int res = findMaxPathSum(root);
            return Math.Max(finalsum,res);
        }

        public int findMaxPathSum(TreeNode node)
        {
            if (node == null)
                return 0;
            
            int val = node.val;
            
            //get both left max and right max first;
            int left  = Math.Max(findMaxPathSum(node.left),0); //but we don't want negative as we can just skip it. so the mininum is 0;
            int right = Math.Max(findMaxPathSum(node.right),0);//same as left, we want to get right max but not negative;
            int allsum = left + right + val;
            finalsum = Math.Max(allsum, finalsum);
            return Math.Max(left,right)+val;
        }
}
