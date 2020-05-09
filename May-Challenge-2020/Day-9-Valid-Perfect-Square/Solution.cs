public class Solution {
    public bool IsPerfectSquare(int num) {
        if (num < -1)
            return false;
        if (num == 0)
            return true;
        
        double start = 1;
        double end = (double)int.MaxValue;
        
        while (start <= end)
        {
            double mid = (start + end) / 2;
            double sqr = mid * mid;
            if (sqr == num)
                return true;
            else if (sqr > num)
                end = mid - 1;
            else
                start = mid + 1;
        }
        return false;
    }
}
