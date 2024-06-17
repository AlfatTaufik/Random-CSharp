// Question
// Given two strings s and t, return true if s is a subsequence of t, or false otherwise.

// A subsequence of a string is a new string that is formed from the original string by deleting some (can be none) of the characters without disturbing the relative positions of the remaining characters. (i.e., "ace" is a subsequence of "abcde" while "aec" is not).

 

// Example 1:

// Input: s = "abc", t = "ahbgdc"
// Output: true
// Example 2:

// Input: s = "axc", t = "ahbgdc"
// Output: false
//  Answwer
public class Solution {
    public bool IsSubsequence(string s, string t) {
        int sPointer = 0;
        int tPointer = 0;
        while(tPointer < t.Length && sPointer < s.Length){
            if(s[sPointer] == t[tPointer]){
                sPointer++;
            }
            tPointer++;
        }
        return sPointer == s.Length;
    }
}