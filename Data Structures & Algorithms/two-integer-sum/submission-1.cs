public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> map = new Dictionary<int, int> ();

        for(int i = 0; i < nums.Length; i++){
            int result = target - nums[i];
            if(map.ContainsKey(result)) return [map[result], i];
            else map.Add(nums[i], i);
        }

        return [];
    }
}
