public class Trie {
    
    private Trie[] children; 
    private bool word;

    /** Initialize your data structure here. */
    public Trie() {
        children = new Trie[26];
        word = false;
    }
    
    /** Inserts a word into the trie. */
    public void Insert(string word) {
        Trie curr = this;
        foreach(char c in word)
        {
            if (curr.children[c - 'a'] == null)
                curr.children[c - 'a'] = new Trie();
            curr = curr.children[c - 'a'];
        }
        curr.word = true;
    }
    
    /** Returns if the word is in the trie. */
    public bool Search(string word) {
        Trie curr = this;
        foreach(char c in word)
        {
            curr = curr.children[c - 'a'];
            if (curr == null)
                return false;
        }
        if (curr.word)
            return true;
        return false;
    }
    
    /** Returns if there is any word in the trie that starts with the given prefix. */
    public bool StartsWith(string prefix) {
        Trie curr= this;
        foreach(char c in prefix)
        {
            curr = curr.children[c - 'a'];
            if (curr == null)
                return false;
        }
        return true;   
    }
}

/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */
