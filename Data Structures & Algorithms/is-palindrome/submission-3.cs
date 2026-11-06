public class Solution {
    public bool IsPalindrome(string s) {
        
        string s_trim = s.Replace(" ", ""); 
        string s_trim_lower = s_trim.ToLower();
        string cleanString = string.Concat(s_trim_lower.Where(char.IsLetterOrDigit));

        int end = cleanString.Length - 1;
        int start = 0;

        while(start <= end){


            if (cleanString[end] != cleanString[start]){

                return false;
            }

            end--;
            start++;

        }

        return true;
    }
}
