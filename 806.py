def numberOfLines( widths, S):
    """
    :type widths: List[int]
    :type S: str
    :rtype: List[int]
    """
    total_line=1
    unfin = 0
    for letter in S:
        A=ord(letter)-97
        if (unfin + widths[A])>100:
            unfin= 0
            total_line=total_line+1
            unfin =unfin + widths[A]
        else:
            unfin = unfin + widths[A]

    final_list= [total_line,unfin]
    return final_list

if __name__=="__main__":
    widths = [4,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10]
    S = "bbbcccdddaaa"
    final_list=numberOfLines(widths, S)
    print (final_list)
