public class Solution {
    public bool IsValid(string s) {

        // s[i] == ')' || s[i] == '}' || s[i] == ']'
        //stack.Count = 0;

        var pairs = new Dictionary<char, char>
            {
                { '(', ')' },
                { '[', ']' },
                { '{', '}' },  
            };
        
        Stack<char> bracket_stack = new Stack<char>();

        for(int i = 0; i < s.Length; i ++){

            if(s[i] == '(' || s[i] == '{' || s[i] == '['){
                
                bracket_stack.Push(s[i]); 
            }
            else{

                if(bracket_stack.Count() == 0){
                    return false;
                }
                char checker = bracket_stack.Pop(); 
                if(pairs[checker] == s[i]){
                    continue;
                }
                else{

                    return false;
                }
            }
        }

        if(bracket_stack.Count() == 0){
            return true;
        }else{

            return false;
        }
    }
}
