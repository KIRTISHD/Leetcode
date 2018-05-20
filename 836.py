def isRectangleOverlap(rec1, rec2):
    """
    :type rec1: List[int]
    :type rec2: List[int]
    :rtype: bool
    """
    #for above
    if rec1[3]<=rec2[1] or rec2[3]<=rec1[1]:
        return False
    #if left
    elif rec1[0]>=rec2[2] or rec2[0]>=rec1[2]:
        return False
    else:
        return True


if __name__=="__main__":
   # rec1 = [0,0,1,1]
    #rec2 = [1,0,2,1]
    rec1 = [0,0,1,1]
    rec2 = [1,0,2,1]
    getitem=isRectangleOverlap(rec1,rec2)
    print(getitem)

