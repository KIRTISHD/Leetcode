public class Solution {
    public string RemoveKdigits(string num, int k) {
        if (k == 0)
            return num;
        if (num == null || num.Length == 0)
            return num;

        int length = num.Length;

       Stack<char> stack = new Stack<char>(); 
        
        for(int i = 0; i < length; i++)
        {
            char current = num[i];
            while(stack.Count > 0 && stack.Peek() > current && k > 0)
            {
                stack.Pop();
                k--;
            }

            stack.Push(current);
        }
        
        while( k > 0 && stack.Count > 0)
        {
            stack.Pop();
            k--;
        }

        var temp = stack.ToArray();
        var numbers = new List<char>(temp);
        
        StringBuilder sb = new StringBuilder();
        bool foundNonZero = false;
        
        for(int i = 0; i < numbers.Count; i++)
        {
            int index = numbers.Count - i - 1;
            char current = numbers[index];
            if (!foundNonZero && current == '0')
            {
                continue;
            }

            foundNonZero = true;
            sb.Append(current);
        }

        return sb.ToString().Length == 0 ? "0" : sb.ToString();
    }
}
