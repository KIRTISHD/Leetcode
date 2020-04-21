/**
 * // This is BinaryMatrix's API interface.
 * // You should not implement it, or speculate about its implementation
 * class BinaryMatrix {
 *     public int Get(int x, int y) {}
 *     public IList<int> Dimensions() {}
 * }
 */

class Solution {
    public int LeftMostColumnWithOne(BinaryMatrix binaryMatrix) {
        IList<int> dim = binaryMatrix.Dimensions();
        int row = dim[0];
        int column = dim[1];
        
        int result = -1;
        int r = 0;
        int c = column-1;
        while(r < row && c >= 0)
        {
            if (binaryMatrix.Get(r,c) == 1)
            {
                result = c;
                c--;
            }
            else
            {
                r++;
            }
        }
        return result;
    }
}
