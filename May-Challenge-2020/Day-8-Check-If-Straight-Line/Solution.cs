public class Solution {
    public bool CheckStraightLine(int[][] coordinates) {
        int len = coordinates.Length;
        double slope = (double)(coordinates[1][1] - coordinates[0][1]) / (coordinates[1][0] - coordinates[0][0]);
        if (len == 2)
            return true;
        double tempslope = 0;
        for(int i = 2 ; i < len ; i++) {
            tempslope = (double)(coordinates[i][1] - coordinates[i-1][1]) / (coordinates[i][0] - coordinates[i-1][0]);
            if (slope != tempslope)
                return false;
        }
        
        return true;
    }
}
