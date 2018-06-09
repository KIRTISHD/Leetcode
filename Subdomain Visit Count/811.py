#Subdomain visit count
class Solution:
    dic = dict()


    def partit(self,S, part):
        return S.partition(part)


    def add(self,S, num):
        if S in Solution.dic.keys():
            Solution.dic[S] = Solution.dic[S] + int(num)
        else:
            Solution.dic[S] = int(num)

        stri = Solution.partit(S, '.')
        if stri[0] in Solution.dic.keys():
            Solution.dic[S[2]] = Solution.dic[S[2]] + int(num)
        if stri[2].__contains__('.'):
            Solution.add(stri[2], num)
        else:
            if stri[2] in Solution.dic.keys():
                Solution.dic[stri[2]] = Solution.dic[stri[2]] + int(num)
            else:
                Solution.dic[stri[2]] = int(num)
        return


    def subdomainVisits(self, cpdomains):
        """
        :type cpdomains: List[str]
        :rtype: List[str]
        """
        self.dic.clear()
        for x in range(len(cpdomains)):
            S = Solution.partit(cpdomains[x], ' ')
            Solution.add(S[2], S[0])

        final_list = list()
        for x, y in Solution.dic.items():
            sss = str(y) + " " + str(x)
            final_list.append(sss)
        return final_list


if __name__=="__main__":
    cases = ["900 google.mail.com", "50 yahoo.com", "1 intel.mail.com", "5 wiki.org"]
    final_list=Solution.subdomainVisits(cases)
    print (final_list)
