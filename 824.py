class Solution:
	def toGoatLatin(S):
		vowels = ["a","e","i","o","u"]
		words = S.split()
		count = 1
		for x in range(len(words)):
			if (words[x][0].lower()=="a" or words[x][0].lower()=="e" or words[x][0].lower()=="i" or words[x][0].lower()=="o" or words[x][0].lower()=="u"):
				words[x] = words[x] + "ma"
			else:
				words[x] = words[x][1:]+words[x][0]
				words[x] = words[x] + "ma"
			words[x] = words[x] + ("a"*count)
			count=count+1
		fin= " ".join(words)
		return fin
		
if __name__=="__main__":
    S = "I speak Goat Latin"
    S1 = "The quick brown fox jumped over the lazy dog"
    final_list=Solution.toGoatLatin(S1)
    print (final_list)
