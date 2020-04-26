public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        System.Collections.Generic.IList<string> sortedList = new System.Collections.Generic.List<string>();
		System.Collections.Generic.Dictionary<string,System.Collections.Generic.IList<string>> sortedDict = new System.Collections.Generic.Dictionary<string,System.Collections.Generic.IList<string>>();	
		System.Collections.Generic.IList<System.Collections.Generic.IList<string>> finalList = new System.Collections.Generic.List<System.Collections.Generic.IList<string>>();	
        
        foreach(var word in strs) {
            char[] temp = word.ToCharArray();
			System.Array.Sort<char>(temp);
			String newword = new String(temp);
			
			if(sortedDict.ContainsKey(newword))
				sortedDict[newword].Add(word);
			else
				sortedDict.Add(newword, new System.Collections.Generic.List<string> {word});
        }
		
		foreach(var x in sortedDict){
			System.Collections.Generic.IList<string> temp = new System.Collections.Generic.List<string>();
			foreach(var str in x.Value){
				temp.Add(str);
			}
			finalList.Add(temp);
		}
        
        return finalList;
    }
}
