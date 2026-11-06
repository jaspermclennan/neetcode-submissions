public class Solution {
    public bool IsPalindrome(string s) {
        
        string s_trim = s.Replace(" ", ""); 

        string s_trim_lower = s_trim.ToLower();


        string cleanString = string.Concat(s_trim_lower.Where(char.IsLetterOrDigit));


        Console.WriteLine(cleanString);

        int end = cleanString.Length - 1;
        int start = 0;

        while(start <= end){

            Console.WriteLine(cleanString[start]);
            Console.WriteLine(cleanString[end]);

            if (cleanString[end] != cleanString[start]){

                return false;
            }

            end = end - 1;
            start = start + 1;

        }

        return true;
    }
}
