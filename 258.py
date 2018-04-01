class Solution:
    def addDigits( num):
        """
        :type num: int
        :rtype: int
        """
        while(num >= 10):
            num = int(num / 10) + (num % 10)
            if (num < 10):
                return num


if __name__=="__main__":
    num=10
    final_list=Solution.addDigits(num)
    print (final_list)