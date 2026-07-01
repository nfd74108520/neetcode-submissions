public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        Dictionary<string, List<int>> result = new Dictionary<string, List<int>>();

        // [-4, -1, -1, 0, 1, 2]
        for (int i = 0; i < nums.Length; i++) {
            int l = i + 1, r = nums.Length - 1;

            while (l < r) {
                int target = nums[i] + nums[l] + nums[r];
                if (target == 0) {
                    result[$"{nums[i]},{nums[l]},{nums[r]}"] = [nums[i], nums[l], nums[r]];
                    l++;
                    r--;
                } else if (target > 0)
                    r--;
                else
                    l++;
            }
        }

        return result.Values.ToList();
    }
}
