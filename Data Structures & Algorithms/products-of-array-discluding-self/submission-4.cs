public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        // [a, b, c, d, e]
        // [bcde, acde, abde, abce, abcd]
        int[] result = new int[nums.Length];

        int lSum = 1;
        for (int l = 0; l < nums.Length; l++) {
            result[l] = lSum;
            lSum *= nums[l];
        }

        int rSum = 1;
        for (int r = nums.Length - 1; r >= 0; r--) {
            result[r] *= rSum;
            rSum *= nums[r];
        }

        return result;
    }
}
