def isAnagram(self, s, t):
        x=list(s)
        y=list(t)
        x.sort()
        y.sort()
        if(x == y):
            return True
        else:
            return False