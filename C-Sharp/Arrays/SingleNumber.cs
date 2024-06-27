// Question
// Given a non-empty array of integers nums, every element appears twice except for one. Find that single one.
// You must implement a solution with a linear runtime complexity and use only constant extra space.

// Answer
using System;
using System.Linq;
using System.Collections.Generic;
public class Solution{
    public int SingleNumber(int[] nums){
        return nums.Aggregate((x, i) => x ^ i);
    }
}