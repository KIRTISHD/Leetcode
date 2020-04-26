public class Solution {
    public bool BackspaceCompare(string S, string T) {
        int Signore = 0,Tignore=0;
        int Spointer = S.Length - 1;
		int Tpointer = T.Length - 1;
		
		while (Spointer >= 0 || Tpointer >= 0) {
			
			while(Spointer >= 0 ){
				if ( S[Spointer] == '#') {
					Spointer--;
					Signore++;
				}
				else if (Signore > 0){
					Spointer--;
					Signore--;
				}
				else 
					break;
			}
			
			while(Tpointer >= 0 ){
				if ( T[Tpointer] == '#') {
					Tpointer--;
					Tignore++;
				}
				else if (Tignore > 0){
					Tpointer--;
					Tignore--;
				}
				else
					break;
			}
			if (Spointer >= 0 && Tpointer >= 0 && S[Spointer] != T[Tpointer])
				return false;
			if (Spointer >= 0 != Tpointer >= 0)
				return false;
			
			Spointer--;
			Tpointer--;
		
		}
		return true;
    }
}
