// Question
// Given an array of integers citations where citations[i] is the number of citations a researcher received for their ith paper, return the researcher's h-index.
// According to the definition of h-index on Wikipedia: The h-index is defined as the maximum value of h such that the given researcher has published at least h papers that have each been cited at least h times.
// Result
using System;
using System.Linq;

public class Solution {
    public int HIndex(int[] citations) {
        var hIndexMax = citations.OrderByDescending(c => c).ToArray();
        var result = 0;
        for(int i = 0; i < hIndexMax.Length ;i++){
            if(hIndexMax[i] >= i + 1){
                result = i + 1;
            }
            else {
                break;
            }
        }
        return result;
    }
}
