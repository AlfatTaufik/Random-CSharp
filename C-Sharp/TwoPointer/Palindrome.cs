// Question
// A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and removing all non-alphanumeric characters, it reads the same forward and backward. Alphanumeric characters include letters and numbers.

// Given a string s, return true if it is a palindrome, or false otherwise.

 

// Example 1:

// Input: s = "A man, a plan, a canal: Panama"
// Output: true
// Explanation: "amanaplanacanalpanama" is a palindrome.
// Example 2:

// Input: s = "race a car"
// Output: false
// Explanation: "raceacar" is not a palindrome.
// Example 3:

// Input: s = " "
// Output: true
// Explanation: s is an empty string "" after removing non-alphanumeric characters.
// Since an empty string reads the same forward and backward, it is a palindrome.
 
// Answer
public class Solution {
    public bool IsPalindrome(string s) {
        s = s.ToLower();
        StringBuilder sb = new StringBuilder();
        foreach(char c in s){
            if(char.IsLetterOrDigit(c)){
                sb.Append(c);
            }
        }
        s = sb.ToString();
        char[] charInS = s.ToCharArray();
        Array.Reverse(charInS);
        string reversedS = new string(charInS);
        if(s == reversedS){
            return true;
        }
        else{
            return false;
        }

    }
}