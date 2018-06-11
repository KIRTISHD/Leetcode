# The isBadVersion API is already defined for you.
# @param version, an integer
# @return a bool
# def isBadVersion(version):

class Solution:
    def firstBadVersion(self, n):
        """
        :type n: int
        :rtype: int
        """
        f,l=0,n
        while f<=l:
            mid=int((f+l)/2)
            if isBadVersion(mid):
                l=mid-1
            else:
                f=mid+1
        return f
