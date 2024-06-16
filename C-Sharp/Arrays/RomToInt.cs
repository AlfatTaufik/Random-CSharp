// Question
// Given a roman numeral, convert it to an integer.
// Answer
public class Solution {
    public int RomanToInt(string s) {
        Dictionary<char, int> romanNum = new Dictionary<char, int>{
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };
         int total = 0;
    for(int i = 0;i < s.Length;i++){
        int currentValue = romanNum[s[i]];
        int nextValue = i + 1 < s.Length ? romanNum[s[i + 1]]:0;

        if(currentValue < nextValue){
            total -= currentValue;
        }
        else{
            total += currentValue;
        }
    }
    return total;
}
}
   