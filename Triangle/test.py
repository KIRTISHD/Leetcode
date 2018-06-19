class Solution:
    def minimumTotal(self, triangle):
        """
        :type triangle: List[List[int]]
        :rtype: int
        """
        arr=[triangle[0][0]]
        for x in range(1,len(triangle)):
            row=triangle[x]
            arr.append(row[-1]+arr[-1])
            for y in range(x-1,0,-1):
                arr[y]=row[y] + min(arr[y], arr[y-1])
            arr[0] = row[0]+arr[0]
        return min(arr)

xyz=Solution()
a=[
     [2],
    [3,4],
   [6,5,7],
  [4,1,8,3]
]
print(xyz.minimumTotal(a))
