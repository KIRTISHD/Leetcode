class Solution:
    def backspaceCompare(self, S, T):
        """
        :type S: str
        :type T: str
        :rtype: bool
        """
        sl = len(S)
        tl = len(T)

        Stemp = list()
        for cha in S:
            if cha != '#':
                Stemp += cha
            else:
                if len(Stemp) > 0:
                    Stemp.pop()

        Ttemp = list()
        for cha in T:
            if cha != '#':
                Ttemp += cha
            else:
                if len(Ttemp) > 0:
                    Ttemp.pop()

        if Stemp==Ttemp:
            return True
        else:
            return False
