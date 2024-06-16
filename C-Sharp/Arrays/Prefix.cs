// Question
// Write a function to find the longest common prefix string amongst an array of strings.
// If there is no common prefix, return an empty string "".

// Answer
public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if(strs.Length == 0){
            return "";
        }

        var prefix = strs[0];
        for(int i = 1;i < strs.Length;i++){
            while(!strs[i].StartsWith(prefix)){
                prefix = prefix.Substring(0, prefix.Length - 1);
            }
        }
        return prefix;
    }
}

