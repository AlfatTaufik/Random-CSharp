// Question
// Given a string s consisting of words and spaces, return the length of the last word in the string.
// A word is a maximal 
// substring
// consisting of non-space characters only.
// Example 1:
// Input: s = "Hello World"
// Output: 5
// Explanation: The last word is "World" with length 5.

// Answer
public class Solution {
    public int LengthOfLastWord(string s) {
        string[] words = s.Trim().Split();
        var lastIndex = words.Length - 1;
        var lastWord = "";
        var totalLetter = 0;
        foreach(var word in words){
            word.Trim();
            if(word == words[lastIndex]){
                lastWord = word;
                foreach(char c in lastWord){
                    totalLetter++;
                }
            }
        }
        return totalLetter;
    }
}