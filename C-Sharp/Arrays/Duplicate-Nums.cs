// Question
// Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.
// Example 1:
// Input: nums = [1,2,3,1]
// Output: true

// Solution
public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        Dictionary<int, int> number = new Dictionary<int, int>();
        bool answer = false;
        for(int i=0;i < nums.Length;i++){
            if(number.ContainsKey(nums[i])){
                answer = true;
            }
            number[nums[i]] = i;
        }
            return answer;
    }
}