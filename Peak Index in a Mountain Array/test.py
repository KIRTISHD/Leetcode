class Solution:
    def peakIndexInMountainArray(self, A):
        """
        :type A: List[int]
        :rtype: int
        """
        l=len(A)
        mid=0
        low = 0
        high = l-1
        while low <=high:
            mid=int((low+high)/2)
            if (A[mid-1] < A[mid]) and (A[mid] > A[mid+1]):
                return mid

            elif (A[mid-1]>A[mid]):
                high = mid
            else:
                low = mid
